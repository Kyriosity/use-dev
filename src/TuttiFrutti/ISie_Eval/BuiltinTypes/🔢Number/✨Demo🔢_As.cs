using ISie.Number.As;
namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_As : ArrangeWithNumbers
{
    [SyntaxDemo]
    public void RomanNumbers() {
        True = "XXI" == 21.As.Roman;
        False = "XX" == 21.As.Roman;
        True = "I" == 1.As.Roman;
        False = "I" == 2.As.Roman;

        True = pangramRoman == 1949.As.Roman;
        True = maxRoman == (3_000 + 900 + 90 + 9).As.Roman;
        False = maxRoman == ((3_000 + 900 + 90 + 9) - 1).As.Roman;
    }

    [SyntaxDemo]
    public void KnownErrors() {
        Error = ArgumentOutOfRange => RomanCantBe(0);
        Error = ArgumentOutOfRange => RomanCantBe(-1);
        Error = ArgumentOutOfRange => RomanCantBe(1 + (int)(3_000 + 900 + 90 + 9));
    }

    private const string maxRoman = "MMMCMXLIX";
    private const string pangramRoman = "MCDXLIV";

    private static string RomanCantBe(int num) => num.As.Roman;
}
