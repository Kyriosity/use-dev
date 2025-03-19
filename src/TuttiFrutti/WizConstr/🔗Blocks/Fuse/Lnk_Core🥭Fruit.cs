namespace WizConstr.Blocks.Fuse;

public abstract class Lnk_Core<TSrc, TRes, Lnk>(TSrc seed) : _base._rightVoid<TSrc, TRes>(seed), ILnkLeftOnly
    where Lnk : fuseFn.IBase<TRes>
{
    internal override Func<TRes, TRes, TRes>? LnkLeft { get; set; } = Unpack<Lnk>();
}

public abstract class Lnk_Fruit<TSrc, TRes, Lnk>(TSrc seed) : Lnk_Core<TSrc, TRes, Lnk>(seed)
    where Lnk : fuseFn.IBase<TRes>
{
    public static implicit operator TRes(Lnk_Fruit<TSrc, TRes, Lnk> source) => source.Yield();
}