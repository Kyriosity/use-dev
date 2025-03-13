namespace WizConstr.Blocks.Fuse._base;

public abstract class _rightFn<TSrc, TRes, Fn>(TSrc seed) : _core<TSrc, TRes>(seed), IFnRight
    where Fn : fuseFn.IBase<TRes>
{
    protected override Type? FnRight { get; } = typeof(Fn);

    public new Blk Next<Blk>()
        where Blk : _core<TSrc, TRes>, INoFnLeft, new()
        => base.Next<Blk>();
}
