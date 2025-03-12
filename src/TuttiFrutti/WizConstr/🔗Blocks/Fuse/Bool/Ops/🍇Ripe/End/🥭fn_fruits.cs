namespace WizConstr.Blocks.Fuse.Bool.Ops.Ripe.End;

public class Or_Fruit<TSrc>(TSrc seed, Func<TSrc, bool> xform) : Ops.Or_Fruit<TSrc>(seed)
{
    protected override bool Eval() => xform(seed);
}

public class And_Fruit<TSrc>(TSrc seed, Func<TSrc, bool> xform) : Ops.And_Fruit<TSrc>(seed)
{
    protected override bool Eval() => xform(seed);
}

public class Xor_Fruit<TSrc>(TSrc seed, Func<TSrc, bool> xform) : Ops.Xor_Fruit<TSrc>(seed)
{
    protected override bool Eval() => xform(seed);
}