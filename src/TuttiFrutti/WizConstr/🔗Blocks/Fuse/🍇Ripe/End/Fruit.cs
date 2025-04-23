using WizConstr.Xform;

namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Fruit<TSrc, TRes> : Fuse.Fruit<TSrc, TRes>, IXFormFuncd<TSrc, TRes>
{
    protected internal override TRes Eval() => Xform(Seed);

    public Func<TSrc, TRes> Xform { get; init; }
}