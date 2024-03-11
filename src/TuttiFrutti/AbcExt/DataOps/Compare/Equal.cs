using System.Text.RegularExpressions;

namespace AbcExt.DataOps.Compare;
public static partial class Equal
{
    public static Func<T, T, bool> Exact<T>() =>
        (a, b) => (a is null && b is null) || (a is not null && b is not null && a.Equals(b));

    public static Func<string?, string?, bool> Loose() =>
        (a, b) => 0 == string.Compare(Normalize(a), Normalize(b), StringComparison.InvariantCultureIgnoreCase);


    private static string Normalize(string? raw) => string.IsNullOrWhiteSpace(raw) ? string.Empty :
    LooseSeparation().Replace(raw.Trim(), " ");

    [GeneratedRegex(@"\s+")]
    private static partial Regex LooseSeparation();
}
