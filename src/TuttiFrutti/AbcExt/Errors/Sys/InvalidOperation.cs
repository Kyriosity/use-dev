namespace AbcExt.Errors.Sys;

public class InvalidOperation : AbcException<InvalidOperationException>
{
    private InvalidOperation() { /* to prevent direct instantiation */ }
}