using System.ComponentModel;

namespace AbcCommu.Errors.Utils;
internal static class Builder
{
    internal static Exc Make<Exc>(string? message = "", Exception? inner = null) where Exc : Exception =>
        Activator.CreateInstance(typeof(Exc), CompileArgs<Exc>(message, inner)) as Exc ??
        throw new InvalidCastException($"Couldn't cast Activator instance to \"{typeof(Exc).FullName}\"");

    private static object[] CompileArgs<Exc>(string? message = "", Exception? inner = null) where Exc : Exception {
        if (inner is null &&
            AmbiguousSignatureTypes.Any(x => x == typeof(Exc)))
            return [message];
        return [message, inner];
    }

    private static readonly Type[] AmbiguousSignatureTypes =
        [typeof(ArgumentException), typeof(ArgumentNullException), typeof(InvalidEnumArgumentException),
        typeof(EntityNotFound), typeof(UniqueConstraint), typeof(DuplicatedArgument), typeof(NotSet)];
}

