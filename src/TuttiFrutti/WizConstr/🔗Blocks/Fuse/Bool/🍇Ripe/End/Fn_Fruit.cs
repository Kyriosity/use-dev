namespace WizConstr.Blocks.Fuse.Bool.Ripe.End;

public class Fn_Fruit<TSrc, Fn>(TSrc seed, Func<TSrc, bool> xform) : Bool.Fn_Fruit<TSrc, Fn>(seed)
    where Fn : fuseFn.IBool
{
    protected override bool Eval() => xform(seed);
}