namespace Abc.Err.Sys;
public static class Argument<T>
{
    public static dynamic Throw() => throw new ArgumentException();
    public static dynamic Throw(string? message) => throw new ArgumentException(message);
    public static dynamic Throw(string? message, Exception? inner) => throw new ArgumentException(message, inner);
}
