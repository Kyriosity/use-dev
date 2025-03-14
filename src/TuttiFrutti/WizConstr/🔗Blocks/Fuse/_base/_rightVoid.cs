namespace WizConstr.Blocks.Fuse._base;

public abstract class _rightVoid<TSrc, TRes>(TSrc seed) : _core<TSrc, TRes>(seed), INoFnRight
{
    public new Blk Next<Blk>() where Blk :
        _core<TSrc, TRes>, IFnLeft, new()
        =>
            base.Next<Blk>();

    public virtual Blk Next<Blk, Fn>() where Blk : _core<TSrc, TRes>, INoFnLeft, new()
        where Fn : fuseFn.IBase<TRes> {

        var block = base.Next<Blk>();
        block.FnLeft = typeof(Fn);
        return block;
    }

    public virtual Ripe.End.Fruit<TSrc, TRes> Next<Fn>(Func<TSrc, TRes> xform)
        where Fn : fuseFn.IBase<TRes>
        =>
            new(seed, xform) { Prev = this }; // ToDo: BETTER ALTERNATIVE WITH INI
}