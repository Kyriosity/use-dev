namespace AbcCommu.Errors.Argument;

public abstract class Exception<Exc>(string message)
    : ArgumentException(message)
    where Exc : ArgumentException
{
    public static dynamic Throw(string message) => throw Builder.Make<Exc>(message);

    public static dynamic Throw<T>(T subject, [ArgExpr(nameof(subject))] string argCall = "[<*unknown*>]")
        => Throw($"*{argCall}*={(subject is null ? "<null>" : subject)}");
}