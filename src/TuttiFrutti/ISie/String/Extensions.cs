using ISie.Mk;
using ISie.Mk.blocks;

namespace ISie.String;
public static class Extensions
{
    public static ICultureNeutral Is(this string value) => new CultureNeutral(value);
    public static ILingua Is<T>(this string val) where T : IScript, ISupported
        => null;
}

// OTHER TYPES EXTANDABLE ! ? ToString() and Custom calls ?

internal class CultureNeutral(string seed) : ICultureNeutral
{
    public bool NullOrEmpty => throw new NotImplementedException();

    public IEndcodingWithGapOption NullEmptyOr => throw new NotImplementedException();

    public IEndcodingWithGapOption EmptyOr => throw new NotImplementedException();

    public bool Whitespace => throw new NotImplementedException();

    public bool Grayspace => NotImplemented.Throw("reserved");

    public bool SingleSpace => throw new NotImplementedException();

    public bool Spaces => throw new NotImplementedException();

    public RMedia Ascii => new(seed);
}