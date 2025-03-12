namespace WizConstr.Blocks.Fuse;

public abstract class Fn_Core_Fn<TSrc, TRes, FnLeft, FnRight>(TSrc seed)
    : _core<TSrc, TRes>(seed), INoFuncLeft, IApplyRight
    where FnLeft : fuseFn.IBase<TRes>
    where FnRight : fuseFn.IBase<TRes>
{
    public new TBk Next<TBk>() where TBk : _core<TSrc, TRes>, INoFuncLeft, new()
        => base.Next<TBk>();
}

public abstract class Fn_Fruit_Fn<TSrc, TRes, FnLeft, FnRight>(TSrc seed)
    : Fn_Core_Fn<TSrc, TRes, FnLeft, FnRight>(seed)
    where FnLeft : fuseFn.IBase<TRes>
    where FnRight : fuseFn.IBase<TRes>

{
    public static implicit operator TRes(Fn_Fruit_Fn<TSrc, TRes, FnLeft, FnRight> source) => source.Yield();
}