using ISie.Number.As;

namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_As : setup.Numbers.Arrange
{
    [SyntaxDemo]
    public void RomanNumbers() {
        True = "XXI" == 21.As.Roman;
        False = "XX" == 21.As.Roman;
        True = "I" == 1.As.Roman;
        False = "I" == 2.As.Roman;

        True = Roman.Pangram == 1949.As.Roman;
        True = Roman.Max == (3_000 + 900 + 90 + 9).As.Roman;
        False = Roman.Max == ((3_000 + 900 + 90 + 9) - 1).As.Roman;
    }

    [SyntaxDraft]
    public void GreekNumbers() {
        _ = 1.As.Greek;
    }

    [SyntaxDemo]
    public void KnownErrors() {
        Error = ArgumentOutOfRange => RomanCantBe(0);
        Error = ArgumentOutOfRange => RomanCantBe(-1);
        Error = ArgumentOutOfRange => RomanCantBe(1 + (int)(3_000 + 900 + 90 + 9));
    }

    private static string RomanCantBe(int num) => num.As.Roman;
}
