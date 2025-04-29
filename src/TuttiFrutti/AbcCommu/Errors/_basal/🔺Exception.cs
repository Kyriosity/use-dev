namespace AbcCommu.Errors.Basal;
public abstract class Exception<Exc>(string? message = "", Exception? inner = null)
    : Exception(message, inner)

    where Exc : Exception
{

    public static dynamic Throw(string message, Exception? inner = null, [ArgExpr(nameof(message))] string _ = argEx)
        => message is "" ? throw New(inner) : throw New(message, inner);

    public static dynamic Throw<T>(T subject, Exception? inner = null, [ArgExpr(nameof(subject))] string argCall = argEx)
        => Throw($"*{argCall}*={(subject is null ? "<null>" : subject)}", inner);

    public static Exc New(string message, Exception? inner = null, [ArgExpr(nameof(message))] string _ = argEx)
        => Builder.Make<Exc>(message, inner);

    public static Exc New<T>(T subject, Exception? inner = null, [ArgExpr(nameof(subject))] string argCall = argEx)
        => New($"*{argCall}*={(subject is null ? "<null>" : subject)}", inner);

    protected const string argEx = "[<*unknown*>]";
}
