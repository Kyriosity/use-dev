namespace WizConstr.Blocks.Fuse;

public abstract class Core<TSrc, TRes>(TSrc seed) : _base._rightVoid<TSrc, TRes>(seed), INoLnkLeft;

public abstract class Fruit<TSrc, TRes>(TSrc seed) : Core<TSrc, TRes>(seed)
{
    public static implicit operator TRes(Fruit<TSrc, TRes> source) => source.Yield();
}