using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse;

public abstract class Lnk_Pulp<T, TRes, Lnk> : basal.rightVoid<T, TRes>, ILnkLeftOnly
    where Lnk : IBase<TRes>
{
    internal override Func<TRes, Func<TRes>, TRes>? LnkLeft { get; set; } = Unpack<Lnk>();
}

public class Lnk_Fruit<T, TRes, Lnk> : Lnk_Pulp<T, TRes, Lnk>
    where Lnk : IBase<TRes>
{
    public static implicit operator TRes(Lnk_Fruit<T, TRes, Lnk> source) => source.Yield();
}