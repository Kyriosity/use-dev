namespace AbcExt.Errors.Sys;
public static class InvalidOperation
{
    public static dynamic Throw() => throw new InvalidOperationException();
    public static dynamic Throw(string? message) => throw new InvalidOperationException(message);
    public static dynamic Throw(string? message, Exception? inner) => throw new InvalidOperationException(message, inner);
}
