namespace WizConstr.Blocks.Fuse;

public abstract class Fn_Core<TSrc, TRes, Fn>(TSrc seed)
    : _core<TSrc, TRes>(seed), INoFuncLeft, IApplyRight
    where Fn : fuseFn.IBase<TRes>
{
    public new TBk Next<TBk>() where TBk : _core<TSrc, TRes>, IApplyLeft, new()
        => base.Next<TBk>();
}

public abstract class Fn_Fruit<TSrc, TRes, Fn>(TSrc seed)
    : Fn_Core<TSrc, TRes, Fn>(seed)
    where Fn : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fn_Fruit<TSrc, TRes, Fn> source) => source.Yield();
}