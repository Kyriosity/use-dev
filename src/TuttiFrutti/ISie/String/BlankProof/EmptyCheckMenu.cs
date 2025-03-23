using ISie.Mk.blocks;
using WizConstr.Blocks.Fuse.Bool.Ops;

namespace ISie.String.BlankProof;
internal class EmptyCheckMenu : Fruit_Or<string>, IEncodingWithGapOption
{
    protected override bool Eval() => Seed is "";

    public Encoding Ascii => throw new NotImplementedException();

    public bool Whitespace => Next(Is.Whitespace);


    public bool SingleSpace => Next(str => str is spaces.Single);

    public bool Spaces => Next(Is.Spaces);
    public bool Grayspace => Next(Is.Grayspace);
}
