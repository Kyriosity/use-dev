using ISie.Number.Calc;
namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_Calculations : setup.Numbers.Arrange
{
    [SyntaxDemo]
    public void Absolute() {
        True = double.Abs(negativeDbl) == negativeDbl.Abs();
        True = int.Abs(minus100) == minus100.Abs();

        // doesn't apply to unsigned types
        //❌ uint.MinValue.Abs();
        //❌ bitsInByte.Abs();
    }

    [SyntaxDemo]
    public void SquareRoot() {
        True = Math.Sqrt(four) == four.Sqrt();
        True = 0 < Math.PI.Sqrt();
        var rootFromNegative = (-samplePositiveFloat).Sqrt();
        True = double.IsNaN((-samplePositiveFloat).Sqrt()); // ToDo replace with coming extension Is.Nan

        // ToDesign: solution on float-point, which can be NaN and negative
        // doesn't apply to integral signed types
        // ❌ int.MaxValue.Sqrt();
    }

    [SyntaxDemo]
    public void Power() {

        True = Math.Pow(2, 1_000) == 2.Pow(1_000);
        _ = 0.Pow(1);

        _ = 10.Pow(-5);
        _ = samplePositiveFloat.Pow(2.345);
    }

    [SyntaxDemo]
    public void Power_Shortcuts() {
        var r = 0.23;
        var circle = r.Square * Math.PI;
        var sphere = r.Cube * Math.PI * 4 / 3;

        Eq[4] = 2.Square;
        Eq[4] = (-2).Square;
        Eq[3 * 3 * 3] = 3.Cube;
        Eq[-27] = (-3).Cube;

        Eq[16_129] = sbyte.MaxValue.Square;
        Eq[2_048_383] = sbyte.MaxValue.Cube;

        True = 0 < samplePositiveFloat.Cube;

    }

    [SyntaxDemo]
    public void TruncateAndRound() {
        Eq[3] = 3.51.Truncate();
        Eq[4] = 3.51.Round();

        Eq[3.14] = Math.PI.Round(2);
    }

    // ToTest: NaN cases
}