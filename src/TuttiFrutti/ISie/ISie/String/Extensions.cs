using ISie.Mk;
using ISie.Mk.blocks;

namespace ISie.String;
public static class Extensions
{
    public static ICultureNeutral Is(this string value) => new CultureNeutral { Value = value };
    public static ILingua Is<T>(this string val) where T : IScript, ISupported
        => null;
}

// OTHER TYPES EXTANDABLE ! ? ToString() and Custom calls ?

internal class CultureNeutral : Core<string>, ICultureNeutral
{
    public bool NullOrEmpty => throw new NotImplementedException();

    public IEndcodingWithGapOption NullEmptyOr => throw new NotImplementedException();

    public IEndcodingWithGapOption EmptyOr => throw new NotImplementedException();

    public bool Whitespace => throw new NotImplementedException();

    public bool Grayspace => throw new NotImplementedException();

    public bool SingleSpace => throw new NotImplementedException();

    public bool Spaces => throw new NotImplementedException();

    public RMedia Ascii => Next<RMedia>();
}