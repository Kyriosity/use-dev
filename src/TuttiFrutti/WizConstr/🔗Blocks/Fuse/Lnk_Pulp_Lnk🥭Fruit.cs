namespace WizConstr.Blocks.Fuse;
public abstract class Lnk_Pulp_Lnk<TSrc, TRes, LnkL, LnkR>
    : basal.rightLnk<TSrc, TRes, LnkR>, ILnkLeftRight

    where LnkL : fuseFn.IBase<TRes> where LnkR : fuseFn.IBase<TRes>
{
    internal override Func<TRes, TRes, TRes>? LnkLeft { get; set; } = Unpack<LnkL>();
}

public abstract class Lnk_Fruit_Lnk<TSrc, TRes, LnkLeft, LnkRight>
    : Lnk_Pulp_Lnk<TSrc, TRes, LnkLeft, LnkRight>

    where LnkLeft : fuseFn.IBase<TRes>
    where LnkRight : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Lnk_Fruit_Lnk<TSrc, TRes, LnkLeft, LnkRight> source) => source.Yield();
}