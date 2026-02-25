using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.StratusApi;
using StratusRevit.SyncEngine;

namespace StratusRevit.PushAgent;

/// <summary>
/// Out-of-process console app that reads a JSON payload from the Revit addin,
/// runs the SyncEngine pipeline (mapping → validation → HTTP calls to Stratus),
/// and writes a JSON result file. Runs on .NET 8 in its own process — zero
/// assembly conflicts with the Revit host.
///
/// Usage:  StratusRevit.PushAgent.exe &lt;payload.json&gt; &lt;result.json&gt;
/// </summary>
public static class Program
{
    private static readonly JsonSerializerOptions JsonOpts = new()
    {
        PropertyNameCaseInsensitive = true,
        WriteIndented = true,
        Converters = { new JsonStringEnumConverter() }
    };

    public static async Task<int> Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.Error.WriteLine("Usage: StratusRevit.PushAgent.exe <payload.json> <result.json>");
            return 1;
        }

        var payloadPath = args[0];
        var resultPath = args[1];

        try
        {
            var payloadJson = await File.ReadAllTextAsync(payloadPath);
            var payload = JsonSerializer.Deserialize<AgentPayload>(payloadJson, JsonOpts);
            if (payload is null)
                throw new InvalidOperationException("Failed to deserialize payload.");

            var result = await RunAsync(payload);
            var resultJson = JsonSerializer.Serialize(result, JsonOpts);
            await File.WriteAllTextAsync(resultPath, resultJson);

            return result.Success ? 0 : 2;
        }
        catch (Exception ex)
        {
            // Write a failure result so the Revit addin always has something to read
            var errorResult = new AgentResult
            {
                Success = false,
                Error = $"{ex.GetType().Name}: {ex.Message}\n{ex.StackTrace}"
            };
            try
            {
                await File.WriteAllTextAsync(resultPath, JsonSerializer.Serialize(errorResult, JsonOpts));
            }
            catch
            {
                // Last resort – write to stderr
                Console.Error.WriteLine(errorResult.Error);
            }
            return 1;
        }
    }

    private static async Task<AgentResult> RunAsync(AgentPayload payload)
    {
        // Wire up DI exactly like DependencyContainer but without Revit references
        var services = new ServiceCollection();

        services.AddLogging(b => b.AddConsole().SetMinimumLevel(LogLevel.Information));

        var apiConfig = new StratusApiConfig
        {
            BaseUrl = payload.ApiConfig.BaseUrl,
            ApiKey = payload.ApiConfig.ApiKey,
            TimeoutSeconds = payload.ApiConfig.TimeoutSeconds,
            MaxRetries = payload.ApiConfig.MaxRetries,
        };

        services.AddSingleton(apiConfig);
        services.AddSingleton(payload.MappingConfig);

        services.AddHttpClient<IStratusApiClient, StratusApiClient>(client =>
        {
            client.BaseAddress = new Uri(apiConfig.BaseUrl.TrimEnd('/') + "/");
            client.Timeout = TimeSpan.FromSeconds(apiConfig.TimeoutSeconds);
        });

        services.AddSingleton<ChangeMapper>();
        services.AddSingleton<AuditLogger>();
        services.AddSingleton<ISyncEngine, StratusRevit.SyncEngine.SyncEngine>();

        await using var sp = services.BuildServiceProvider();
        var engine = sp.GetRequiredService<ISyncEngine>();

        // Convert payload elements to domain records
        var elements = payload.Elements
            .Select(e => e.ToRevitElementData())
            .ToList()
            .AsReadOnly();

        SyncReport report;
        if (payload.Mode == AgentMode.DryRun)
            report = await engine.DryRunAsync(elements);
        else
            report = await engine.PushUpdatesAsync(elements);

        return new AgentResult
        {
            Success = report.ChangesFailed == 0,
            IsDryRun = report.IsDryRun,
            TotalElements = report.TotalElements,
            ChangesPlanned = report.ChangesPlanned,
            ChangesSucceeded = report.ChangesSucceeded,
            ChangesFailed = report.ChangesFailed,
            Results = report.Results.Select(r => new AgentChangeResult
            {
                StratusObjectId = r.StratusObjectId,
                RevitElementId = r.RevitElementId,
                FieldName = r.FieldName,
                OldValue = r.OldValue,
                NewValue = r.NewValue,
                IsSuccess = r.IsSuccess,
                ErrorMessage = r.ErrorMessage
            }).ToList()
        };
    }
}
