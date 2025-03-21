using AbcRefl.Implementation;

namespace WizConstr.Blocks;

public abstract class Core<TSrc, TRes> : Xform.Core<TSrc, TRes>
{
    internal virtual Func<TRes, TRes, TRes>? LnkLeft { get; set; } = null;
    internal virtual Func<TRes, TRes, TRes>? LnkRight => null;

    protected static Func<TRes, TRes, TRes> Unpack<I>() =>
        (argL, argR) => (TRes)Method.Default<I>(nameof(fuseFn.IBase<TRes>.Join)).Invoke(argL, argR);

    internal Core<TSrc, TRes>? Prev { get; init; }
    public virtual TBk Next<TBk>() where TBk : Core<TSrc, TRes>, new()
        => new() { Seed = Seed, Prev = this };
}