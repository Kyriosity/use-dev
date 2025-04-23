namespace WizConstr.Blocks.Fuse.basal;

public abstract class rightLnk<TSrc, TRes, Lnk> : pulp<TSrc, TRes>, ILnkRight
    where Lnk : fuseFn.IBase<TRes>
{
    internal override Func<TRes, TRes, TRes>? LnkRight { get; } = Unpack<Lnk>();

    protected new Blk Next<Blk>()
        where Blk : pulp<TSrc, TRes>, INoLnkLeft, new()

        => base.Next<Blk>();

    public Ripe.End.Fruit<TSrc, TRes> Next(Func<TSrc, TRes> xform) => new() { Xform = xform, Seed = Seed, Prev = this };
}
