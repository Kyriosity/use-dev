namespace AbcStoppers.Errors.Sys;

public class InvalidOperation : Exception<InvalidOperationException>
{
    private InvalidOperation() { /* to prevent direct instantiation */ }
}