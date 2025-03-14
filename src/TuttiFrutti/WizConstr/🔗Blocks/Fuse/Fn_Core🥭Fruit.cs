namespace WizConstr.Blocks.Fuse;

public abstract class Fn_Core<TSrc, TRes, Fn>(TSrc seed) : _base._rightVoid<TSrc, TRes>(seed), IFnLeftOnly
    where Fn : fuseFn.IBase<TRes>
{
    internal override Type? FnLeft { get; set; } = typeof(Fn);
}

public abstract class Fn_Fruit<TSrc, TRes, Fn>(TSrc seed) : Fn_Core<TSrc, TRes, Fn>(seed)
    where Fn : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fn_Fruit<TSrc, TRes, Fn> source) => source.Yield();
}