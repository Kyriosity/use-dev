namespace WizConstr.Blocks.Fuse._base;

public abstract class RightLnk<TSrc, TRes, Lnk> : _core<TSrc, TRes>, ILnkRight
    where Lnk : fuseFn.IBase<TRes>
{
    protected override Func<TRes, TRes, TRes>? LnkRight { get; } = Unpack<Lnk>();

    public new Blk Next<Blk>()
        where Blk : _core<TSrc, TRes>, INoLnkLeft, new() =>
        base.Next<Blk>();
}
