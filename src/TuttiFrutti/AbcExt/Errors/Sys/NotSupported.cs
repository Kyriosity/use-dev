namespace AbcExt.Errors.Sys;

public class NotSupported : Basal.Exception<NotSupportedException>
{
    private NotSupported() { /* to prevent direct instantiation */ }
}
