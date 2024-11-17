namespace AbcDataOps.Compare;
public static partial class Equal
{
    public static Func<T, T, bool> Exact<T>() =>
        (left, right) => (left is null && right is null) || (left is not null && right is not null && left.Equals(right));

    public static Func<string?, string?, bool> Loose =>
        (left, right) => 0 == string.Compare(Normalize(left), Normalize(right), StringComparison.InvariantCultureIgnoreCase);

    private static string Normalize(string? raw) => string.IsNullOrWhiteSpace(raw) ? string.Empty :
        LooseSeparation().Replace(raw.Trim(), " ");

    [GeneratedRegex(@"\s+")]
    private static partial Regex LooseSeparation();
}