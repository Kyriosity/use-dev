namespace AbcLingua.Rules.ext;
public static class SetterShortcuts
{
    extension<T>(T core) where T : Numbers.Rank.IEdit
    {
        public T Ordinal() {
            core.Rank = Numbers.Rank.Values.Ordinal;
            return core;
        }
    }

    extension<T>(T core) where T : Grammar.Quantity.IEdit
    {
        public T Plural() {
            core.Quantity = Grammar.Quantity.Values.Plural;
            return core;
        }
    }

    //https://worldschoolbooks.com/number-systems-in-different-languages/
}