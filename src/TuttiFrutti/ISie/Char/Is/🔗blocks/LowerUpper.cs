namespace ISie.Char.Is.Blocks;
public class LowerUpper : Fruit_And<char>, ILowerUpper<bool>
{
    public bool Lower => Next(char.IsLower);

    public bool Upper => Next(char.IsUpper);
}
