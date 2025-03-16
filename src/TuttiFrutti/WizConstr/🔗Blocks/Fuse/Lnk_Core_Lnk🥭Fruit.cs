namespace WizConstr.Blocks.Fuse;

public abstract class Lnk_Core_Lnk<TSrc, TRes, LnkL, LnkR>(TSrc seed) : _base.RightLnk<TSrc, TRes, LnkR>(seed), ILnkLeftRight

    where LnkL : fuseFn.IBase<TRes> where LnkR : fuseFn.IBase<TRes>

{
    internal override Type? LnkLeft { get; set; } = typeof(LnkL);
}

public abstract class Lnk_Fruit_Lnk<TSrc, TRes, LnkLeft, LnkRight>(TSrc seed)
    : Lnk_Core_Lnk<TSrc, TRes, LnkLeft, LnkRight>(seed)

    where LnkLeft : fuseFn.IBase<TRes>
    where LnkRight : fuseFn.IBase<TRes>

{
    public static implicit operator TRes(Lnk_Fruit_Lnk<TSrc, TRes, LnkLeft, LnkRight> source) => source.Yield();
}