using Abc.Selection;
using AbcCommu.Errors.Sys;

namespace ISie.Char.Is.Blocks;
public class LowerUpper : Fruit_And<char>, ILowerUpper<bool>
{
    public bool Lower => char.IsLower(Seed);

    public bool Upper => char.IsUpper(Seed);

    protected override bool Eval() => NotImplemented.Throw("will be replaced with breaking change !");
}
