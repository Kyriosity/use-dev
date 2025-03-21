namespace WizConstr.Blocks.Fuse._base;

public abstract class _rightVoid<TSrc, TRes> : _core<TSrc, TRes>, INoLnkRight
{
    public new Blk Next<Blk>() where Blk :
        _core<TSrc, TRes>, ILnkLeft, new()
        =>
            base.Next<Blk>();

    public virtual Blk Next<Blk, Lnk>() where Blk : _core<TSrc, TRes>, INoLnkLeft, new()
        where Lnk : fuseFn.IBase<TRes> {

        var block = base.Next<Blk>();
        block.LnkLeft = Unpack<Lnk>();
        return block;
    }

    public virtual Ripe.End.Lnk_Fruit<TSrc, TRes, Lnk> Next<Lnk>(Func<TSrc, TRes> xform)
        where Lnk : fuseFn.IBase<TRes>
        =>
            new() { Seed = Seed, Prev = this, Xform = xform }; // ToDo: BETTER ALTERNATIVE WITH INI
}