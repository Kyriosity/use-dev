namespace WizConstr.Blocks.Fuse._base;

public abstract class _rightVoid<TSrc, TRes>(TSrc seed) : _core<TSrc, TRes>(seed), INoFnRight
{
    public new Blk Next<Blk>() where Blk : _core<TSrc, TRes>, IFnLeft, new() =>
        base.Next<Blk>();

    // ToDo: PARAM NEXT !
}
