using AbcExt.Errors.Argument;
using AbcExt.Errors.Data;
using System.ComponentModel;

namespace AbcExt.Errors.Shortcuts;
internal static class Builder
{
    internal static TExc Make<TExc>(string? message = "", Exception? inner = null) where TExc : Exception =>
        (Activator.CreateInstance(typeof(TExc), CompileArgs<TExc>(message, inner)) as TExc) ??
        throw new InvalidCastException($"Couldn't cast Activator instance to \"{typeof(TExc).FullName}\"");

    private static object[] CompileArgs<TExc>(string? message = "", Exception? inner = null) where TExc : Exception {
        if (inner is null &&
            AmbiguousSignatureTypes.Any(x => x == typeof(TExc)))
            return [message];
        return [message, inner];
    }

    private static readonly Type[] AmbiguousSignatureTypes =
        [typeof(ArgumentException), typeof(ArgumentNullException), typeof(InvalidEnumArgumentException),
        typeof(EntityNotFound), typeof(UniqueConstraint), typeof(DuplicatedArgument)];
}

