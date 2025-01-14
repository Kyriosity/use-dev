namespace Abc.Lingua.turkic.east;
public abstract class Kazakh : Family
{
    public abstract class Cyrillic : ICyrillic, ISupported;
    public abstract class Latin : ILatin, ISupported;
    public abstract class Arabic : IScript, ISupported;
    public abstract class Braille : IScript;
}
