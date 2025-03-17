namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Fruit<TSrc, TRes>(TSrc seed, Func<TSrc, TRes> xform) : Fuse.Fruit<TSrc, TRes>(seed)
{
    protected internal override TRes Eval() => xform(seed);
}

