using ISie.Mk;
using ISie.Mk.blocks;

namespace ISie.String;
public static class Extensions
{
    public static ICultureNeutral Is(this string value) => new CultureNeutral(value);
    //public static ILingua Is<T>(this string value) where T : INumber<T> => Encoding, Extended ASCIIs, ?Unicode;
    public static ILingua Is<T>(this string value) where T : IScript, ISupported => null;
}

// OTHER TYPES EXTENDABLE ! ? ToString() and Custom calls ?

internal class CultureNeutral(string seed) : ICultureNeutral
{
    public bool NullOrEmpty => throw new NotImplementedException();

    public IEncodingWithGapOption NullEmptyOr => throw new NotImplementedException();

    public IEncodingWithGapOption EmptyOr => throw new NotImplementedException();

    public bool Whitespace => new Wiz.Ripe.End.Fruit<string>(seed, str =>
        string.Empty != str && string.IsNullOrWhiteSpace(str));

    public bool Grayspace => NotImplemented.Throw("reserved for the discussion: +control chars?");

    public bool SingleSpace => throw new NotImplementedException();

    public bool Spaces => throw new NotImplementedException();

    public Encoding Ascii => new(seed);
}