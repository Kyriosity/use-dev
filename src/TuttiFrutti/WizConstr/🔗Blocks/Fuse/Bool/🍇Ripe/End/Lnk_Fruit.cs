namespace WizConstr.Blocks.Fuse.Bool.Ripe.End;

public class Lnk_Fruit<TSrc, Lnk>(TSrc seed, Func<TSrc, bool> xform) : Bool.Lnk_Fruit<TSrc, Lnk>(seed)
    where Lnk : fuseFn.IBool
{
    protected internal override bool Eval() => xform(seed);
}