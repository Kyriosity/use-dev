using ISie.Number.Calc;

namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_Calculations : Setup.ArrangeWithNumbers
{
    [Test]
    public void Absolute() {
        True = double.Abs(negativeDbl) == negativeDbl.Abs();
        True = int.Abs(minus100) == minus100.Abs();

        // doesn't apply to unsigned types
        //❌ uint.MinValue.Abs();
        //❌ bitsInByte.Abs();
    }

    [Test]
    public void SquareRoot() {
        True = Math.Sqrt(fourUnsigned) == fourUnsigned.Sqrt();
        True = 0 < samplePositiveFloat.Sqrt();
        var c = (-samplePositiveFloat).Sqrt();
        True = double.IsNaN((-samplePositiveFloat).Sqrt()); // ToDo replace with coming extension Is.Nan

        // ToDesign: solution on float-point, which can be NaN and negative

        // doesn't apply to integral signed types
        // ❌ int.MaxValue.Sqrt();
    }

    [Test]
    public void Power() {

        True = Math.Pow(2, 1_000) == 2.Pow(1_000);
        _ = 0.Pow(1);

        _ = 10.Pow(-5);
        _ = samplePositiveFloat.Pow(2.345);
    }

    // ToTest: NaN cases

}
