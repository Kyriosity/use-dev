using WizConstr.Xform;

namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Lnk_Fruit<TSrc, TRes, Lnk> : Fuse.Lnk_Fruit<TSrc, TRes, Lnk>, IXFormFunction<TSrc, TRes>
    where Lnk : fuseFn.IBase<TRes>
{
    protected internal override TRes Eval() => Xform(Seed);
    public Func<TSrc, TRes> Xform { get; init; }
}