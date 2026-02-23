namespace StratusRevit.Domain;

public record ChangeReport(
    DateTimeOffset GeneratedAt,
    int TotalElements,
    int ValidChanges,
    int InvalidChanges,
    IReadOnlyList<ChangeIntent> Intents
)
{
    public static ChangeReport From(IReadOnlyList<ChangeIntent> intents)
        => new(
            GeneratedAt: DateTimeOffset.UtcNow,
            TotalElements: intents.Count,
            ValidChanges: intents.Count(i => i.IsValid),
            InvalidChanges: intents.Count(i => !i.IsValid),
            Intents: intents
        );
}
