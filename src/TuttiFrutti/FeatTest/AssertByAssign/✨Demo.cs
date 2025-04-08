namespace FeatTest.AssertByAssign;
public class Demo : Basal
{
    [SyntaxDemo]
    public void Basics() {
        Assert.That(TruthValueFunction("any argument"), Is.True); // descriptive, meaningful but long
        True = TruthValueFunction("any argument"); // dubious but terser with emphasized test subjects 
        False = TruthValueFunction("any argument"); // 👈 will fail 👈

        string? checker = null;
        Assert.That(checker, Is.Null);
        Null = checker;

        int operand = 0;
        Assert.That(5 * operand, Is.Zero);
        Zero = 5 * operand;
    }

    [SyntaxDemo]
    public void Exceptions() {
        Assert.Throws<DivideByZeroException>(() => DivideBy(0));
        Error = DivideByZero => DivideBy(0);

        OkOrErr = OverflowException => Increment(byte.MaxValue); // 👈 will either cycle or overflow dependent on project settings
        // there's no corresponding Assert but will be try/catch clause
    }

    [SyntaxDemo]
    public void Variables() { // ALGOL68/Fortran fashion
        Eq[-5] = -5;
        NE[1] = 1;

        Gt[7] = 10;
        GE[7] = 15;

        LE[1] = 1;
        Lt[1] = 2;
    }
}
