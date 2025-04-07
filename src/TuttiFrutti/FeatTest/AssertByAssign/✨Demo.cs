namespace FeatTest.AssertByAssign;
public class Demo : Basal
{
    [SyntaxDemo]
    public void Basics() {
        // descriptive, meaningful but long
        Assert.That(TruthValueFunction("any argument"), Is.True);
        // dubious but shorter with emphasized subjects 
        True = TruthValueFunction("any argument");
        False = TruthValueFunction("any argument"); // 👈 will fail 👈


        string? checker = null;
        Assert.That(checker, Is.Null);
        Null = checker;

        int operand = 0;
        Assert.That(5 * operand, Is.Zero);
        Zero = 5 * operand;
    }

    [SyntaxDemo]
    public void Variables() { // ALGOL / Fortran style
        Eq[-5] = -5;
        NE[1] = 1;

        Gt[7] = 10;
    }

    [Test]
    public void Exceptions() {
        Assert.Throws<DivideByZeroException>(() => DivideBy(0));
        Error = DivideByZero => DivideBy(0);

        OkOrErr = OverflowException => Increment(byte.MaxValue); // 👈 will either cycle or overflow dependent on project settings
        // there's no corresponding Assert but will be try/catch clause
    }
}
