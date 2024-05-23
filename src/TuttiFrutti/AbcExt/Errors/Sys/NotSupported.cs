namespace AbcExt.Errors.Sys;

public class NotSupported : AbcException<NotSupportedException>
{
    private NotSupported() { /* to prevent direct instantiation */ }
}
