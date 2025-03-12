namespace WizConstr.Blocks.Fuse;

public abstract class Core_Fn<TSrc, TRes, Fn>(TSrc seed)
    : _core<TSrc, TRes>(seed), INoFuncLeft, IApplyRight
   where Fn : fuseFn.IBase<TRes>
{
    public new TBk Next<TBk>() where TBk : _core<TSrc, TRes>, INoFuncLeft, new()
        => base.Next<TBk>();
}

public abstract class Fruit_Fn<TSrc, TRes, Fn>(TSrc seed)
    : Core_Fn<TSrc, TRes, Fn>(seed)
    where Fn : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fruit_Fn<TSrc, TRes, Fn> source) => source.Yield();
}