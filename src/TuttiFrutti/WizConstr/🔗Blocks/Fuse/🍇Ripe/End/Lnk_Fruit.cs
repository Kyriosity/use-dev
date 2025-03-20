namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Lnk_Fruit<TSrc, TRes, Lnk>(Func<TSrc, TRes> xform) : Fuse.Lnk_Fruit<TSrc, TRes, Lnk>
    where Lnk : fuseFn.IBase<TRes>
{
    protected internal override TRes Eval() => xform(Seed);
}