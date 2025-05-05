using Abc.Logic.Fuse.Lazy;
using AbcRefl.Implementation;

namespace WizConstr.Blocks;

public abstract class Pulp<T, TRes> : Xform.Pulp<T, TRes>
{
    internal virtual Func<TRes, Func<TRes>, TRes>? LnkLeft { get; set; } = null;
    internal virtual Func<TRes, Func<TRes>, TRes>? LnkRight => null;

    protected static Func<TRes, Func<TRes>, TRes> Unpack<I>() => (left, right) =>
        (TRes)Method.Default<I>(nameof(IBase<TRes>.Join)).Invoke(left, right);

    internal Pulp<T, TRes>? Prev { get; init; }
    protected new TBk Next<TBk>()
        where TBk : Pulp<T, TRes>, new() =>
                new() { Seed = Seed, Prev = this };

    protected TBk Next<TBk>(Func<T, TRes> xform)
     where TBk : Pulp<T, TRes>, new() {

        var pulp = Next<TBk>(); pulp.XForm = xform;
        return pulp;
    }
}