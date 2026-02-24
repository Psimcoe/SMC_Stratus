namespace StratusRevit.Domain;

public class ChangeValidator
{
    private readonly HashSet<string> _validTrackingStatusIds;
    private readonly HashSet<string> _editableFieldNames;

    public ChangeValidator(
        IEnumerable<string> validTrackingStatusIds,
        IEnumerable<string> editableFieldNames)
    {
        _validTrackingStatusIds = new HashSet<string>(validTrackingStatusIds);
        _editableFieldNames = new HashSet<string>(editableFieldNames);
    }

    public ChangeIntent Validate(ChangeIntent intent)
    {
        var errors = new List<string>();

        if (intent.TrackingStatusChange is not null)
        {
            if (!_validTrackingStatusIds.Contains(intent.TrackingStatusChange.NewValue))
                errors.Add($"Tracking status '{intent.TrackingStatusChange.NewValue}' is not a valid tracking status ID.");
        }

        foreach (var fieldChange in intent.CustomFieldChanges)
        {
            if (!_editableFieldNames.Contains(fieldChange.FieldName))
                errors.Add($"Field '{fieldChange.FieldName}' is not editable.");
        }

        if (errors.Count == 0)
            return intent;

        return intent with { IsValid = false, ValidationErrors = errors.AsReadOnly() };
    }

    public IReadOnlyList<ChangeIntent> ValidateAll(IReadOnlyList<ChangeIntent> intents)
        => intents.Select(Validate).ToList().AsReadOnly();
}
