namespace WizConstr.Blocks.Fuse.Bool.Ops.Ripe.End;

public class Or_Fruit<TSrc>(Func<TSrc, bool> xform) : Ops.Or_Fruit<TSrc>
{
    protected internal override bool Eval() => xform(Seed); // ToDesign: NO SEED ARG ! 
    // ToDo: COMMON xform()
}

public class And_Fruit<TSrc>(Func<TSrc, bool> xform) : Ops.And_Fruit<TSrc>
{
    protected internal override bool Eval() => xform(Seed);
}

public class Xor_Fruit<TSrc>(Func<TSrc, bool> xform) : Ops.Xor_Fruit<TSrc>
{
    protected internal override bool Eval() => xform(Seed);
}