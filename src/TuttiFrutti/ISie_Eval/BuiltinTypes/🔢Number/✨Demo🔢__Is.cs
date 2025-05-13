using ISie.Number.Is;
namespace ISie_Eval.BuiltinType.Number;
public class Demo_Is : ArrangeWithNumbers
{
    [SyntaxDraft]
    public void NaturalNumbers() {
        True = bitsInByte.Is.Odd;
        False = bitsInByte.Is.Even;
        True = bitsInByte.Is.PowOf2;

        _ = int100.Is.NaturalOr0;
        False = int100.Is.NaturalOr0.PowOf2;
    }

    [SyntaxDraft]
    public void Floating() {
        True = (1 / 0.00).Is.Finite;
        _ = 0.1.Is.NaN;
        True = negativeDbl.Is.Normal;
        False = negativeDbl.Is.Subnormal;
    }

    [SyntaxDraft]
    public void FloatingAsIntegral() {
        _ = (10 / 2.0).Is.Integer;
        _ = (2.0 / 5.0).Is.Integer;
    }

    [SyntaxDraft]
    public void Naturalization() {
        _ = intNegative.Is.NaturalOr0;

        _ = gdpEU.Is.NaturalOr0;
        True = gdpEU.Is.NaturalOr0.Odd;

        _ = samplePositiveFloat.Is.NaturalOr0;

        _ = negativeDbl.Is.Integer;
        False = int100.Is.NaturalOr0.PowOf2;
    }

    /// <summary>
    /// Uncomment before release to prove that no line can be compiled
    /// </summary>
    [SyntaxDraft]
    public void InvalidSyntax() {
        // _ = bitsInByte.Is.NaturalOr0; 🚫
        _ = ((sbyte)bitsInByte).Is.NaturalOr0; // 🆗

        //_ = ulong.MaxValue.Is.NaturalOr0; 🚫

        // _ = -16.Is.PowOf2; // 🚫
        // _ = 16.Is.PowOf2; // 🚫
        True = ((uint)16).Is.PowOf2; // 🆗

    }
}
