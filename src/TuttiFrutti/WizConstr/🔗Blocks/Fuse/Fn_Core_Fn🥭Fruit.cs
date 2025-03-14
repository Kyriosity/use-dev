namespace WizConstr.Blocks.Fuse;

public abstract class Fn_Core_Fn<TSrc, TRes, FnL, FnR>(TSrc seed) : _base._rightFn<TSrc, TRes, FnR>(seed), IFnLeftRight
    where FnL : fuseFn.IBase<TRes> where FnR : fuseFn.IBase<TRes>
{
    internal override Type? FnLeft { get; set; } = typeof(FnL);
}

public abstract class Fn_Fruit_Fn<TSrc, TRes, FnLeft, FnRight>(TSrc seed)
    : Fn_Core_Fn<TSrc, TRes, FnLeft, FnRight>(seed)
    where FnLeft : fuseFn.IBase<TRes>
    where FnRight : fuseFn.IBase<TRes>

{
    public static implicit operator TRes(Fn_Fruit_Fn<TSrc, TRes, FnLeft, FnRight> source) => source.Yield();
}