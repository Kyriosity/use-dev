using ISie.Number.Mathe;

namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_Math : Setup.ArrangeWithNumbers
{
    [Test]
    public void Absolute() {
        True = double.Abs(negativeDbl) == negativeDbl.Abs();
        True = int.Abs(minus100) == minus100.Abs();

        // doesn't apply to unsigned types
        //❌ uint.MinValue.Abs();
        //❌ bitsInByte.Abs();
    }

    [SyntaxDemo]
    public void SquareRoot() {
        True = Math.Sqrt(fourUnsigned) == fourUnsigned.Sqrt();

        // ToDesign: solution on float-point, which can be NaN and negative

        // doesn't apply to integral signed types
        // ❌ int.MaxValue.Sqrt();
    }

    // ToTest: NaN cases

}
