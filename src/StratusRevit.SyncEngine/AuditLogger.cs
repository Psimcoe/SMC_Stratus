using Microsoft.Extensions.Logging;

namespace StratusRevit.SyncEngine;

public class AuditLogger
{
    private readonly ILogger<AuditLogger> _logger;

    public AuditLogger(ILogger<AuditLogger> logger)
    {
        _logger = logger;
    }

    public void LogAttempt(ChangeResult result)
    {
        if (result.IsSuccess)
        {
            _logger.LogInformation(
                "[AUDIT] SUCCESS | StratusId={StratusId} RevitId={RevitId} Field={Field} Old={Old} New={New} At={At}",
                result.StratusObjectId, result.RevitElementId, result.FieldName,
                result.OldValue, result.NewValue, result.Timestamp);
        }
        else
        {
            _logger.LogWarning(
                "[AUDIT] FAILURE | StratusId={StratusId} RevitId={RevitId} Field={Field} Error={Error} At={At}",
                result.StratusObjectId, result.RevitElementId, result.FieldName,
                result.ErrorMessage, result.Timestamp);
        }
    }
}
