namespace AbcCommu.Errors.Sys;

public class NotSupported : Exception<NotSupportedException>
{
    private NotSupported() { /* to prevent direct instantiation */ }
}
