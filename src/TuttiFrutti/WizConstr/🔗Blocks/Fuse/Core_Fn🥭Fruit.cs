namespace WizConstr.Blocks.Fuse;

public abstract class Core_Fn<TSrc, TRes, Fn>(TSrc seed) : _base._rightFn<TSrc, TRes, Fn>(seed), IFnRightOnly
    where Fn : fuseFn.IBase<TRes>;


public abstract class Fruit_Fn<TSrc, TRes, Fn>(TSrc seed) : Core_Fn<TSrc, TRes, Fn>(seed)
    where Fn : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fruit_Fn<TSrc, TRes, Fn> source) => source.Yield();
}