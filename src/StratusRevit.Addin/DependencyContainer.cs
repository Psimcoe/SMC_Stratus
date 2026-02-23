using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.RevitAdapter.Revit2025;
using StratusRevit.StratusApi;
using StratusRevit.SyncEngine;

namespace StratusRevit.Addin;

public static class DependencyContainer
{
    public static IServiceProvider Build(StratusAddinConfig addinConfig, MappingConfig mappingConfig)
    {
        var services = new ServiceCollection();

        services.AddLogging(b => b.AddConsole());

        var apiConfig = new StratusApiConfig
        {
            BaseUrl = addinConfig.BaseUrl,
            ApiKey = addinConfig.ApiKey,
            TimeoutSeconds = addinConfig.TimeoutSeconds,
            MaxRetries = addinConfig.MaxRetries,
        };

        services.AddSingleton(apiConfig);
        services.AddSingleton(mappingConfig);

        services.AddHttpClient<IStratusApiClient, StratusApiClient>(client =>
        {
            client.BaseAddress = new Uri(apiConfig.BaseUrl.TrimEnd('/') + "/");
            client.Timeout = TimeSpan.FromSeconds(apiConfig.TimeoutSeconds);
        });

        services.AddSingleton<ChangeMapper>();
        services.AddSingleton<AuditLogger>();
        services.AddSingleton<ISyncEngine, StratusRevit.SyncEngine.SyncEngine>();
        services.AddSingleton<IRevitContext, Revit2025Context>();
        services.AddSingleton<IRevitHostInfo, Revit2025HostInfo>();

        return services.BuildServiceProvider();
    }
}
