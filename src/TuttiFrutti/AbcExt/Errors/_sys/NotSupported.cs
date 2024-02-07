namespace AbcExt.Errors.Sys;
public static class NotSupported
{
    public static dynamic Throw() => throw new NotSupportedException();
    public static dynamic Throw(string? message) => throw new NotSupportedException(message);
    public static dynamic Throw(string? message, Exception? inner) => throw new NotSupportedException(message, inner);
}
