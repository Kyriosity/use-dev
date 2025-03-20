namespace WizConstr.Blocks.Fuse.Bool.Ripe.End;

public class Lnk_Fruit<TSrc, Lnk>(Func<TSrc, bool> xform) : Bool.Lnk_Fruit<TSrc, Lnk>
    where Lnk : fuseFn.IBool
{
    protected internal override bool Eval() => xform(Seed);
}