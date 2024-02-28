namespace AbcExt.Errors.Shortcuts;
public abstract class Direct<TExc>(string? message = "", Exception? inner = null)
    : Exception(message, inner) where TExc : Exception
{
    private static readonly Type _selfType = typeof(TExc);

    public static dynamic Throw(string? message = "", Exception? inner = null) => throw
        (Activator.CreateInstance(_selfType, [message, inner]) as TExc) ??
        new Exception($"Couldn't cast to \"{typeof(TExc).FullName}\"");

    public static dynamic Throw<T>(T subject, Exception? inner = null) => Throw($"{subject}", inner);
}
