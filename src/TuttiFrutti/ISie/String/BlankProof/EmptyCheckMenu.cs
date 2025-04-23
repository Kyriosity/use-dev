using ISie.Mk.blocks;
using WizConstr.Blocks.Fuse.Bool.Ops;

namespace ISie.String.BlankProof;
internal class EmptyCheckMenu : Fruit_Or<string>, IEncodingWithGapOption
{
    protected override bool Eval() => Seed is "";

    public Encoding Ascii => Next<Encoding>();

    public bool Whitespace => Next(AbcDataOps.Text.Func.Is.Whitespace);

    public bool SingleSpace => Next(str => str is spaces.Single);

    public bool Spaces => Next(AbcDataOps.Text.Func.Is.Spaces);
    public bool Grayspace => Next(AbcDataOps.Text.Func.Is.Grayspace);
}
