namespace WizConstr.Blocks.Fuse.Ripe.End;

public class Fn_Fruit<TSrc, TRes, Fn>(TSrc seed, Func<TSrc, TRes> xform) : Fuse.Fn_Fruit<TSrc, TRes, Fn>(seed)
    where Fn : fuseFn.IBase<TRes>
{
    protected override TRes Eval() => xform(seed);
}