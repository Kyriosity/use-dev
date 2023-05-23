namespace Abc.Err.Sys;
public static class NotImplemented
{
    public static dynamic Throw() => throw new NotImplementedException();
    public static dynamic Throw(string? message) => throw new NotImplementedException(message);
    public static dynamic Throw(string? message, Exception? inner) => throw new NotImplementedException(message, inner);
}
