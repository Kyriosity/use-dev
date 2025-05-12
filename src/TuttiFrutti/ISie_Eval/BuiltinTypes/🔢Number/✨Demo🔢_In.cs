using AbcLingua.Tongues;
using ISie.Number.In;
namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_In : Setup.ArrangeWithNumbers
{
    [SyntaxDemo]
    public void Basic_Wording() {
        uint year = 2025;
        _ = $"This project began in the year: {year.In<English>()}";
        _ = DateTime.Today.Day.In<Latin>();
        _ = ulong.MaxValue.In<English>();

        short angle = 45;
        _ = angle.In<Greek>();

        var uno = 1.In<Current>();
        var minusOne = (1 - 2).In<Current>();

        // ToDo: add nullable variants
    }

    [SyntaxDemo]
    public void Float() {
        decimal sum = 724.50M;
        var report = $"total: {sum.In<Current>()}";

        float? calc = -0.050_801F;
        _ = calc.In<English>();
        _ = double.Pi.In<French>(); // challenge - how many numbers at long fraction?
    }

    [SyntaxDemo]
    public void RomanNumbers() {
        // no zero and negatives
    }

    public void MiscFormats() {

    }

    // .FRACTION_STYLE - words or ?; // .Words;
}
