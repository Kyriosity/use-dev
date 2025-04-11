namespace FeatTest.AssertByAssign;
public class Demo_Errors : Basal
{
    [SyntaxDemo]
    public void Exceptions() {
        Assert.Throws<DivideByZeroException>(() => DivideBy(0));
        Error = DivideByZero => DivideBy(0);

        Assert.Throws<FieldAccessException>(() => { _ = Dummy.ErrorGetter; });
        Error = FieldAccessException => Dummy.ErrorGetter;
    }

    [SyntaxDemo]
    public void Bit_diff_Syntax_for_VoidMethods() {
        Err = InvalidOperationException => InvalidAction(1); // Err instead of Error
    }

    [SyntaxDemo]
    public void PossibleException() {
        OkOrErr = OverflowException => Increment(byte.MaxValue); // 👈 will either cycle or overflow dependent on project settings
        // there's no corresponding Assert but will be try/catch clause
    }
}
