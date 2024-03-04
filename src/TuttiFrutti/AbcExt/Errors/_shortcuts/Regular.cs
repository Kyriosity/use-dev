using System.ComponentModel;

namespace AbcExt.Errors.Shortcuts;
public abstract class Regular<TExc>(string? message = "", Exception? inner = null)
    : Exception(message, inner) where TExc : Exception
{
    private static readonly Type _selfType = typeof(TExc);

    public static dynamic Throw(string? message = "", Exception? inner = null) => throw New(message, inner);

    public static dynamic Throw<T>(T subject, Exception? inner = null) => Throw($"{subject}", inner);

    public static TExc New(string? message = "", Exception? inner = null) =>
        (Activator.CreateInstance(_selfType, CompileArgs<TExc>(message, inner)) as TExc) ??
        throw new InvalidCastException($"Couldn't cast Activator instance to \"{typeof(TExc).FullName}\"");

    public static TExc New<T>(T subject, Exception? inner = null) => New($"{subject}", inner);

    private static object[] CompileArgs<TExc>(string? message = "", Exception? inner = null) where TExc : Exception {
        if (inner is null &&
            AmbiguousSignatureTypes.Any(x => x == typeof(TExc)))
            return [message];
        return [message, inner];

    }

    private static readonly Type[] AmbiguousSignatureTypes =
        [typeof(ArgumentException), typeof(ArgumentNullException), typeof(InvalidEnumArgumentException)];
}

