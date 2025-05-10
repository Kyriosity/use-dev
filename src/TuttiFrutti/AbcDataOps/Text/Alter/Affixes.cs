using AbcDataOps.Text.Relate;

namespace AbcDataOps.Text.Alter;
public static class Affixes
{
    extension(string source)
    {

        public string SuffixIfNone(string affix, StringComparison comparison = StringComparison.Ordinal) =>
            source.Right() == affix ? source : $"{source}{affix}";

        public string PrefixIfNone(string affix, StringComparison comparison = StringComparison.Ordinal) =>
            source.Left() == affix ? source : $"{source}{affix}";

        public Mid Right(StringComparison comparison = StringComparison.Ordinal) => new(false, source, comparison);
        public Mid Left(StringComparison comparison = StringComparison.Ordinal) => new(true, source, comparison);
    }
}