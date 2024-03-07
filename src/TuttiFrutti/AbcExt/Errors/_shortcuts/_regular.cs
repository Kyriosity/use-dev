using AbcExt.Errors._shortcuts;

namespace AbcExt.Errors.Shortcuts;
public abstract class Regular<TExc>(string? message = "", Exception? inner = null) : Exception(message, inner)
    where TExc : Exception
{
    public static dynamic Throw(string? message = "", Exception? inner = null) => throw New(message, inner);

    public static dynamic Throw<T>(T subject, Exception? inner = null) => Throw($"{subject}", inner);

    public static TExc New(string? message = "", Exception? inner = null) => Builder.Make<TExc>(message, inner);

    public static TExc New<T>(T subject, Exception? inner = null) => New($"{subject}", inner);
}