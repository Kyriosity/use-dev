namespace FeatTest.AssertByAssign;
public abstract class Basal : AbcExtNUnit.Asserted.Full
{
    internal TestClass Dummy = new();
    protected static int DivideBy(int divisor) => 5 / divisor;

    protected void Increment(byte arg) {
        unchecked {
            arg++;
            arg--;
        }
        // next will throw Overflow exception provided Project Properties/Build/Advanced/✅Check for arithmetic overflow 
        arg++;
    }

    protected void ValidAction(int arg) { var description = $"{arg} supplied"; }

    protected void InvalidAction(int arg) => throw new InvalidOperationException("for test purposes only");

}

public class TestClass
{
    internal bool ThrowNotReturnIf(bool doThrow)
        => doThrow ? throw new ArgumentException($"{doThrow}") : doThrow;

    public bool Ok => true;

    public bool ErrorGetter {
        get => throw new FieldAccessException("for demo purposes only");
        set { }
    }
    public string SetFail {
        get => "CANT SET THIS";
        set => throw new NotImplementedException("FOR DEMO PURPOSES");
    }
}