using System;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using StratusRevit.Domain;

namespace StratusRevit.Addin.Revit2023;

/// <summary>
/// Launches the out-of-process PushAgent (net8.0) to run the SyncEngine pipeline.
/// This avoids all assembly version conflicts because HTTP calls happen in a
/// separate process with its own .NET runtime—outside the Revit host process.
/// </summary>
public static class AgentLauncher
{
    /// <summary>
    /// Serialises the payload to a temp JSON file, launches PushAgent.exe,
    /// waits for it to finish, and returns the deserialised result.
    /// </summary>
    public static AgentResult Run(string addinDir, AgentPayload payload, JsonSerializerOptions jsonOpts)
    {
        var tempDir = Path.Combine(Path.GetTempPath(), "StratusRevit");
        Directory.CreateDirectory(tempDir);

        var stamp = DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");
        var payloadPath = Path.Combine(tempDir, $"payload_{stamp}.json");
        var resultPath = Path.Combine(tempDir, $"result_{stamp}.json");

        try
        {
            // Write payload
            File.WriteAllText(payloadPath, JsonSerializer.Serialize(payload, jsonOpts));

            // Locate agent exe
            var agentExe = Path.Combine(addinDir, "agent", "StratusRevit.PushAgent.exe");
            if (!File.Exists(agentExe))
                throw new FileNotFoundException(
                    $"PushAgent not found at: {agentExe}\nEnsure the agent folder is deployed alongside the addin.");

            // Launch
            var psi = new ProcessStartInfo
            {
                FileName = agentExe,
                Arguments = $"\"{payloadPath}\" \"{resultPath}\"",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };

            using var proc = Process.Start(psi);
            if (proc is null)
                throw new InvalidOperationException("Failed to start PushAgent process.");

            var stderr = proc.StandardError.ReadToEnd();
            var stdout = proc.StandardOutput.ReadToEnd();
            proc.WaitForExit(120_000); // 2 minute timeout

            if (!proc.HasExited)
            {
                proc.Kill();
                throw new TimeoutException("PushAgent did not complete within 2 minutes.");
            }

            // Read result
            if (!File.Exists(resultPath))
            {
                throw new InvalidOperationException(
                    $"PushAgent exited with code {proc.ExitCode} but no result file was written.\n" +
                    $"stdout: {stdout}\nstderr: {stderr}");
            }

            var resultJson = File.ReadAllText(resultPath);
            var result = JsonSerializer.Deserialize<AgentResult>(resultJson, jsonOpts)
                ?? throw new InvalidOperationException("Failed to deserialise agent result.");

            return result;
        }
        finally
        {
            // Clean up temp files
            TryDelete(payloadPath);
            TryDelete(resultPath);
        }
    }

    private static void TryDelete(string path)
    {
        try { if (File.Exists(path)) File.Delete(path); } catch { /* best-effort */ }
    }
}
