using System.ComponentModel;

namespace AbcCommu.Errors.Utils;
internal static class Builder
{
    internal static Exc Make<Exc>(string? message = "", Exception? inner = null) where Exc : Exception =>
        Activator.CreateInstance(typeof(Exc), CompileArgs<Exc>(message, inner)) as Exc ??
        throw new InvalidCastException($"Couldn't cast Activator instance to \"{typeof(Exc).FullName}\"");

    private static object[] CompileArgs<Exc>(string? message = "", Exception? inner = null) where Exc : Exception {
        var typeOfExc = typeof(Exc);

        if (inner is null) {
            if (_ambiguousSignatureType.IsAssignableFrom(typeOfExc) ||
                AmbiguousSignatureTypes.Any(x => x == typeof(Exc)))
                return [message];
        }
        return [message, inner];
    }

    private static readonly Type[] AmbiguousSignatureTypes =
        [typeof(ArgumentException), typeof(ArgumentNullException), typeof(InvalidEnumArgumentException)];
    //👆 list other system and foreign types when added here

    private static readonly Type _ambiguousSignatureType = typeof(IHasAmbiguousSignature);
}

public interface IHasAmbiguousSignature;