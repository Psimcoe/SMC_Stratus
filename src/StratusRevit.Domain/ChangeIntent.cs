namespace StratusRevit.Domain;

public record FieldChange(string FieldName, string? OldValue, string NewValue);

public record ChangeIntent(
    string StratusObjectId,
    string StratusObjectType,
    string RevitElementId,
    string RevitUniqueId,
    FieldChange? TrackingStatusChange,
    IReadOnlyList<FieldChange> CustomFieldChanges,
    bool IsValid,
    IReadOnlyList<string> ValidationErrors
);
