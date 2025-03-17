namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Lnk_Fruit<TSrc, TRes, Lnk>(TSrc seed, Func<TSrc, TRes> xform) : Fuse.Lnk_Fruit<TSrc, TRes, Lnk>(seed)
    where Lnk : fuseFn.IBase<TRes>
{
    protected internal override TRes Eval() => xform(seed); // ToDo: COMMON OVERRIDE !
}