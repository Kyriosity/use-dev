namespace AbcCommu.Errors.Sys;

public class InvalidOperation : Basal.Exception<InvalidOperationException>
{
    private InvalidOperation() { /* to prevent direct instantiation */ }
}