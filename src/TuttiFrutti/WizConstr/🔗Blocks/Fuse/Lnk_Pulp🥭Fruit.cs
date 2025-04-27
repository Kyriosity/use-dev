namespace WizConstr.Blocks.Fuse;

public abstract class Lnk_Pulp<TSrc, TRes, Lnk> : basal.rightVoid<TSrc, TRes>, ILnkLeftOnly
    where Lnk : fuseFn.IBase<TRes>
{
    internal override Func<TRes, TRes, TRes>? LnkLeft { get; set; } = Unpack<Lnk>();
}

public class Lnk_Fruit<TSrc, TRes, Lnk> : Lnk_Pulp<TSrc, TRes, Lnk>
    where Lnk : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Lnk_Fruit<TSrc, TRes, Lnk> source) => source.Yield();
}