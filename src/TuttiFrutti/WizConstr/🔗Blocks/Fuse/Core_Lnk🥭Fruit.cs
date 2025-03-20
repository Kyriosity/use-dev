namespace WizConstr.Blocks.Fuse;

public abstract class Core_Lnk<TSrc, TRes, Lnk> : _base.RightLnk<TSrc, TRes, Lnk>, ILnkRightOnly
    where Lnk : fuseFn.IBase<TRes>;


public abstract class Fruit_Lnk<TSrc, TRes, Lnk> : Core_Lnk<TSrc, TRes, Lnk>
    where Lnk : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fruit_Lnk<TSrc, TRes, Lnk> source) => source.Yield();
}