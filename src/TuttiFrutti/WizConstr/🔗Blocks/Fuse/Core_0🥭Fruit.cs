namespace WizConstr.Blocks.Fuse;

public abstract class Core<TSrc, TRes>(TSrc seed) : _core<TSrc, TRes>(seed), ILeftNoFunc, IRightNoFunc
{
    public new Blk Next<Blk>() where Blk : _core<TSrc, TRes>, IApplyLeft, new() =>
        base.Next<Blk>();
}

public abstract class Fruit<TSrc, TRes>(TSrc seed) : Core<TSrc, TRes>(seed)
{
    public static implicit operator TRes(Fruit<TSrc, TRes> source) => source.Yield();
}