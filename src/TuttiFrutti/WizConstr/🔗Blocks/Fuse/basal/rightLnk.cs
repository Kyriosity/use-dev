namespace WizConstr.Blocks.Fuse.basal;

public abstract class rightLnk<TSrc, TRes, Lnk> : core<TSrc, TRes>, ILnkRight
    where Lnk : fuseFn.IBase<TRes>
{
    internal override Func<TRes, TRes, TRes>? LnkRight { get; } = Unpack<Lnk>();

    public new Blk Next<Blk>()
        where Blk : core<TSrc, TRes>, INoLnkLeft, new()

        => base.Next<Blk>();

    public Ripe.End.Fruit<TSrc, TRes> Next(Func<TSrc, TRes> xform) => new() { Xform = xform, Seed = Seed, Prev = this };
}
