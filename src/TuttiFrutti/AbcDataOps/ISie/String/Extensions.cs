using AbcDataOps.ISie.Mk;
using AbcDataOps.ISie.Mk.blocks;

namespace AbcDataOps.ISie.String;
public static class Extensions
{
    public static ICultureNeutral Is(this string val) => new CultureNeutral();
    public static ILingua Is<T>(this string val) where T : IScript, ISupported
        => null;
}

// OTHER TYPES EXTANDABLE ! ? ToString() and Custom calls ?

internal class CultureNeutral : ICultureNeutral
{
    public bool NullOrEmpty => throw new NotImplementedException();

    public IEndcodingWithGapOption NullEmptyOr => throw new NotImplementedException();

    public IEndcodingWithGapOption EmptyOr => throw new NotImplementedException();

    public bool Whitespace => throw new NotImplementedException();

    public bool Grayspace => throw new NotImplementedException();

    public bool SingleSpace => throw new NotImplementedException();

    public bool Spaces => throw new NotImplementedException();

    public Media Ascii => throw new NotImplementedException();
}