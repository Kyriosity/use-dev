namespace ISie_Eval.BuiltinType.Number;
public class Demo_Is
{
    [Test]
    public void TestNaN() {

        double testie = double.NaN;

        var ispow = double.IsPow2(testie);
        // throw NaN
    }

}
