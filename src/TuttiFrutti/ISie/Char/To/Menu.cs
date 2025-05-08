using Abc.Logic.Circuitry.Bool;

namespace ISie.Char.To;
public interface IMenu
{
    char Upper { get; }
    char UpperInvariant { get; }
    char Lower { get; }
    char LowerInvariant { get; }
}

internal class Menu(char seed) : Root<char, IOWire>(seed), IMenu
{
    public char Upper => char.ToUpper(Seed);

    public char UpperInvariant => char.ToUpperInvariant(Seed);

    public char Lower => char.ToLower(Seed);

    public char LowerInvariant => char.ToLowerInvariant(Seed);
}