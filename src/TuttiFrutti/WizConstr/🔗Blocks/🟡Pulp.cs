using AbcRefl.Implementation;

namespace WizConstr.Blocks;

public abstract class Pulp<T, TRes> : Xform.Pulp<T, TRes>
{
    internal virtual Func<TRes, TRes, TRes>? LnkLeft { get; set; } = null;
    internal virtual Func<TRes, TRes, TRes>? LnkRight => null;

    protected static Func<TRes, TRes, TRes> Unpack<I>() =>
        (argL, argR) => (TRes)Method.Default<I>(nameof(fuseFn.IBase<TRes>.Join)).Invoke(argL, argR);

    internal Pulp<T, TRes>? Prev { get; init; }
    protected virtual TBk Next<TBk>()
        where TBk : Pulp<T, TRes>, new()

        => new() { Seed = Seed, Prev = this };

    protected virtual TBk Next<TBk>(Func<T, TRes> xform)
     where TBk : Pulp<T, TRes>, new() {

        var pulp = Next<TBk>(); pulp.XForm = xform;
        return pulp;
    }
}