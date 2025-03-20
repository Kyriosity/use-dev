namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Fruit<TSrc, TRes>(Func<TSrc, TRes> xform) : Fuse.Fruit<TSrc, TRes>
{
    protected internal override TRes Eval() => xform(Seed);
}

