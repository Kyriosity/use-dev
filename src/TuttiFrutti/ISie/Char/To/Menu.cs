namespace ISie.Char.To;
public interface IMenu
{
    char Upper { get; }
    char UpperInvariant { get; }
    char Lower { get; }
    char LowerInvariant { get; }
}

internal class Menu : RootMenu<char>, IMenu
{
    public Menu(char seed) : base(seed) { }

    public char Upper => char.ToUpper(Seed);

    public char UpperInvariant => char.ToUpperInvariant(Seed);

    public char Lower => char.ToLower(Seed);

    public char LowerInvariant => char.ToLowerInvariant(Seed);
}