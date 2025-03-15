namespace WizConstr.Blocks.Fuse._base;

public abstract class _rightVoid<TSrc, TRes>(TSrc seed) : _core<TSrc, TRes>(seed), INoLnkRight
{
    public new Blk Next<Blk>() where Blk :
        _core<TSrc, TRes>, ILnkLeft, new()
        =>
            base.Next<Blk>();

    public virtual Blk Next<Blk, Lnk>() where Blk : _core<TSrc, TRes>, INoLnkLeft, new()
        where Lnk : fuseFn.IBase<TRes> {

        var block = base.Next<Blk>();
        block.LnkLeft = typeof(Lnk);
        return block;
    }

    public virtual Ripe.End.Fruit<TSrc, TRes> Next<Lnk>(Func<TSrc, TRes> xform)
        where Lnk : fuseFn.IBase<TRes>
        =>
            new(seed, xform) { Prev = this }; // ToDo: BETTER ALTERNATIVE WITH INI
}