namespace AbcStoppers.Errors.Sys;
public class NullReference : Exception<NullReferenceException>
{
    private NullReference() { /* to prevent direct instantiation */ }
}
