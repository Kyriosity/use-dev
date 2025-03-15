namespace WizConstr.Blocks.Fuse;

public abstract class Core_Lnk<TSrc, TRes, Lnk>(TSrc seed) : _base.RightLnk<TSrc, TRes, Lnk>(seed), ILnkRightOnly
    where Lnk : fuseFn.IBase<TRes>;


public abstract class Fruit_Lnk<TSrc, TRes, Lnk>(TSrc seed) : Core_Lnk<TSrc, TRes, Lnk>(seed)
    where Lnk : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fruit_Lnk<TSrc, TRes, Lnk> source) => source.Yield();
}