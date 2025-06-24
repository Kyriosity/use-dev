using AbcLingua.Rules.Grammar;
using AbcLingua.Rules.Numeric;

namespace AbcLingua.Rules.ext;
public static class SetterShortcuts
{
    extension<T>(T core) where T : IRank_Edit
    {
        public T Ordinal(bool val = true) {
            core.IsOrdinal = val;
            return core;
        }
    }

    extension<T>(T core) where T : IQuantity_Edit
    {
        public T Plural() {
            core.Plurality = Quantity.Plural;
            return core;
        }
    }
}