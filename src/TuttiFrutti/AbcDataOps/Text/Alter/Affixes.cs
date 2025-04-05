using AbcDataOps.Text.Relate;

namespace AbcDataOps.Text.Alter;
public static class Affixes
{
    public static string SuffixIfNone(this string source, string affix, StringComparison comparison = StringComparison.Ordinal) =>
        source.Right() == affix ? source : $"{source}{affix}";



    public static string PrefixIfNone(this string source, string affix, StringComparison comparison = StringComparison.Ordinal) =>
        source.Left() == affix ? source : $"{source}{affix}";

    // ToDesign: on demand - additive partial affixes

    public static Mediator Right(this string source, StringComparison comparison = StringComparison.Ordinal) => new(false, source, comparison);
    public static Mediator Left(this string source, StringComparison comparison = StringComparison.Ordinal) => new(true, source, comparison);
}

