using Abc.Selection;

namespace ISie.Char.Is.Blocks;
public class LowerUpper : Fruit_And<char>, ILowerUpper<bool>
{
    public bool Lower => char.IsLower(Seed);

    public bool Upper => char.IsUpper(Seed);


}
