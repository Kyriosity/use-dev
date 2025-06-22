using AbcLingua.Rules.Numeric;

namespace AbcLingua.Rules.ext;
public static class SetterShortcuts
{
    extension<T>(T seed) where T : IRank_Edit
    {
        public T Ordinal(bool val = true) {
            seed.IsOrdinal = val;
            return seed;
        }
    }
}
