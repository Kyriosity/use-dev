namespace AbcExt.Errors.Shortcuts;
public abstract class Regular<TExc> : Exception where TExc : Exception
{
    protected Regular(string? message = "", Exception? inner = null) : base(message, inner) { }

    private static readonly Type _selfType = typeof(TExc);

    public static dynamic Throw(string? message = "", Exception? inner = null) => throw
        (Activator.CreateInstance(_selfType, CompileArgs(message, inner)) as TExc) ??
        new Exception($"Couldn't cast to \"{typeof(TExc).FullName}\"");

    public static dynamic Throw<T>(T subject, Exception? inner = null) => Throw($"{subject}", inner);

    private static object[] CompileArgs(string? message = "", Exception? inner = null) => inner is null ?
        [message] : [message, inner];
}

