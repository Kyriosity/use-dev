namespace WizConstr.Blocks.Fuse;

public abstract class Pulp_Lnk<TSrc, TRes, Lnk> : basal.rightLnk<TSrc, TRes, Lnk>, ILnkRightOnly
    where Lnk : fuseFn.IBase<TRes>;

public abstract class Fruit_Lnk<TSrc, TRes, Lnk> : Pulp_Lnk<TSrc, TRes, Lnk>
    where Lnk : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Fruit_Lnk<TSrc, TRes, Lnk> source) => source.Yield();
}