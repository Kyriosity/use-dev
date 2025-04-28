namespace ISie.Char.Is.Blocks;
public class Surrogates : Fruit_And<char>, ILowHigh<bool>
{
    public bool Low => Next(char.IsLowSurrogate);

    public bool High => Next(char.IsHighSurrogate);
}