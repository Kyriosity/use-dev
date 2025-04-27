using AbcRefl.Implementation;

namespace WizConstr.Blocks;

public abstract class Pulp<TSrc, TRes> : Xform.Pulp<TSrc, TRes>
{
    internal virtual Func<TRes, TRes, TRes>? LnkLeft { get; set; } = null;
    internal virtual Func<TRes, TRes, TRes>? LnkRight => null;

    protected static Func<TRes, TRes, TRes> Unpack<I>() =>
        (argL, argR) => (TRes)Method.Default<I>(nameof(fuseFn.IBase<TRes>.Join)).Invoke(argL, argR);

    internal Pulp<TSrc, TRes>? Prev { get; init; }
    protected virtual TBk Next<TBk>()
        where TBk : Pulp<TSrc, TRes>, new()

        => new() { Seed = Seed, Prev = this };

    protected virtual TBk Next<TBk>(Func<TSrc, TRes> xform)
     where TBk : Pulp<TSrc, TRes>, new() {

        var pulp = Next<TBk>(); pulp.XForm = xform;
        return pulp;
    }
}