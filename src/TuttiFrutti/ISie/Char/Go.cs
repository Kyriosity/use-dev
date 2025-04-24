namespace ISie.Char;
public static class Go
{
    public static ICharTraitsMenu Is(this char seed) => null;
    public static To.IMenu To(this char seed) => new To.Menu(seed);
}

public interface ICharTraitsMenu
{
    IAscii Ascii { get; }
}

public interface IAscii
{
    bool Digit { get; }
    bool LetterOrDigit { get; }

    ILetterCase HexDigit { get; } // Lower Upper

    ILetterCase Letter { get; } // Lower Upper

}

public interface ILetterCase
{
    bool Lower { get; }
    bool Upper { get; }
}
