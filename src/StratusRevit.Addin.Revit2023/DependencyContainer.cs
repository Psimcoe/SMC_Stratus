using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using StratusRevit.Domain;
using StratusRevit.RevitAdapter.Abstractions;
using StratusRevit.RevitAdapter.Revit2023;
using StratusRevit.StratusApi;
using StratusRevit.SyncEngine;

namespace StratusRevit.Addin.Revit2023;

public static class DependencyContainer
{
    public static IServiceProvider Build(StratusAddinConfig addinConfig, MappingConfig mappingConfig,
        Revit2023Context revitContext)
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

        // Use the pre-initialised Revit 2023 context
        services.AddSingleton<IRevitContext>(revitContext);
        services.AddSingleton<IRevitHostInfo, Revit2023HostInfo>();

        return services.BuildServiceProvider();
    }
}
