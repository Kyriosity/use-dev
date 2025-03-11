namespace WizConstr.Blocks.Fuse;

public abstract class Core_Fn<TSrc, TRes, TFn>(TSrc seed) : _core<TSrc, TRes>(seed), ILeftNoFunc, IApplyRight // ToDo: TFn -> GENERIC!
   where TFn : fuseFn.IBase<TRes>
{
    public new TBk Next<TBk>() where TBk : _core<TSrc, TRes>, ILeftNoFunc, new()
        => base.Next<TBk>();
}
