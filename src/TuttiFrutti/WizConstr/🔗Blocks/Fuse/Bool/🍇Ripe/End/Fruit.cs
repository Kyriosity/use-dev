namespace WizConstr.Blocks.Fuse.Bool.Ripe.End;

public class Fruit<TSrc>(Func<TSrc, bool> xform) : Bool.Fruit<TSrc>
{
    protected internal override bool Eval() => xform(Seed);
}
