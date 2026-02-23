using System.Text.Json;

namespace StratusRevit.Addin;

public class StratusAddinConfig
{
    public string BaseUrl { get; set; } = "https://api.gtpstratus.com";
    public string ApiKey { get; set; } = "";
    public int TimeoutSeconds { get; set; } = 30;
    public int MaxRetries { get; set; } = 3;
    public string MappingConfigPath { get; set; } = "mapping.json";

    public static StratusAddinConfig LoadFromFile(string path)
    {
        if (!File.Exists(path)) return new StratusAddinConfig();
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<StratusAddinConfig>(json) ?? new StratusAddinConfig();
    }
}
