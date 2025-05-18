namespace AbcStoppers.Errors.Argument;
public abstract class OutOfRange<Exc>(string message) : ArgumentOutOfRangeException(message)
    where Exc : ArgumentOutOfRangeException
{
    public static dynamic Throw(string message) => throw Builder.Make<Exc>(message);

    public static dynamic Throw<T>(T subject, [ArgExpr(nameof(subject))] string argCall = "[<*unknown*>]")
    => Throw($"*{argCall}*={(subject is null ? "<null>" : subject)}");
}