namespace FeatTest.setup;
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