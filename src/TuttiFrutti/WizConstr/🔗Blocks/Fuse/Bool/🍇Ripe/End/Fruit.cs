namespace WizConstr.Blocks.Fuse.Bool.Ripe.End;

public class Fruit<TSrc>(TSrc seed, Func<TSrc, bool> xform) : Bool.Fruit<TSrc>(seed)
{
    protected internal override bool Eval() => xform(seed);
}
