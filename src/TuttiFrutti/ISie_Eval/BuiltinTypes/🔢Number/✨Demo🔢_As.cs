using ISie.Number.As;
namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_As : ArrangeWithNumbers
{
    [SyntaxDemo]
    public void RomanNumbers() {
        True = "XX" == 21.As.Roman;
        // 

        //"MCDXLIV";

        const string biggestRoman = "MMMCMXLIX";

    }

    [SyntaxDemo]
    public void KnownErrors() {
        Error = ArgumentOutOfRange => RomanCantBe(0);
        Error = ArgumentOutOfRange => RomanCantBe(-1);
    }

    private static string RomanCantBe(int num) => num.As.Roman;
}
