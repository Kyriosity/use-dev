namespace AbcExtNUnit.Exceptions;
public class Assertion : AbcStoppers.Errors.Basal.Exception<AssertionException>
{
    private Assertion() { /* to prevent direct instantiation */ }
}
