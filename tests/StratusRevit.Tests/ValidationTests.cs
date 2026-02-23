using StratusRevit.Domain;

namespace StratusRevit.Tests;

public class ValidationTests
{
    private static ChangeIntent ValidIntent(FieldChange? tsChange = null, List<FieldChange>? fieldChanges = null)
        => new(
            StratusObjectId: "obj-1",
            StratusObjectType: "Assembly",
            RevitElementId: "elem-1",
            RevitUniqueId: "unique-1",
            TrackingStatusChange: tsChange,
            CustomFieldChanges: (fieldChanges ?? new List<FieldChange>()).AsReadOnly(),
            IsValid: true,
            ValidationErrors: Array.Empty<string>()
        );

    [Fact]
    public void Validate_ValidTrackingStatus_Passes()
    {
        var validator = new ChangeValidator(
            new HashSet<string> { "ts-001" },
            new HashSet<string> { "Comments" });

        var intent = ValidIntent(tsChange: new FieldChange("trackingStatus", null, "ts-001"));
        var result = validator.Validate(intent);
        Assert.True(result.IsValid);
        Assert.Empty(result.ValidationErrors);
    }

    [Fact]
    public void Validate_InvalidTrackingStatus_Fails()
    {
        var validator = new ChangeValidator(
            new HashSet<string> { "ts-001" },
            new HashSet<string> { "Comments" });

        var intent = ValidIntent(tsChange: new FieldChange("trackingStatus", null, "ts-invalid"));
        var result = validator.Validate(intent);
        Assert.False(result.IsValid);
        Assert.NotEmpty(result.ValidationErrors);
    }

    [Fact]
    public void Validate_NonEditableField_Fails()
    {
        var validator = new ChangeValidator(
            new HashSet<string>(),
            new HashSet<string> { "EditableField" });

        var intent = ValidIntent(fieldChanges: new List<FieldChange>
        {
            new("ReadOnlyField", null, "value")
        });
        var result = validator.Validate(intent);
        Assert.False(result.IsValid);
        Assert.Contains(result.ValidationErrors, e => e.Contains("ReadOnlyField"));
    }

    [Fact]
    public void ValidateAll_MultipleIntents_ReturnsSameCount()
    {
        var validator = new ChangeValidator(
            new HashSet<string> { "ts-001" },
            new HashSet<string> { "Comments" });

        var intents = new List<ChangeIntent>
        {
            ValidIntent(tsChange: new FieldChange("trackingStatus", null, "ts-001")),
            ValidIntent(tsChange: new FieldChange("trackingStatus", null, "ts-bad"))
        };
        var results = validator.ValidateAll(intents);
        Assert.Equal(2, results.Count);
        Assert.True(results[0].IsValid);
        Assert.False(results[1].IsValid);
    }
}
