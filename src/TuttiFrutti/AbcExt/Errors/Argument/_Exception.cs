using AbcExt.Errors.Utils;

namespace AbcExt.Errors.Argument;

public abstract class Exception<TExc>(string message)
    : ArgumentException(message)
    where TExc : ArgumentException
{
    public static dynamic Throw(string message) => throw Builder.Make<TExc>(message);

    public static dynamic Throw<T>(T subject, [ArgExpr(nameof(subject))] string argCall = "[<*unknown*>]")
        => Throw($"*{argCall}*={(subject is null ? "<null>" : subject)}");
}