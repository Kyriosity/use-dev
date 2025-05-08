using Abc.Logic.Fuse.Lazy;
using AbcRefl.Implementation;

namespace WizConstr.Blocks.Fuse.basal;

public abstract class pulp<T, TRes> : Blocks.Pulp<T, TRes>
{
    internal virtual Func<TRes, Func<TRes>, TRes>? LnkLeft { get; set; } = null;
    internal virtual Func<TRes, Func<TRes>, TRes>? LnkRight => null;

    protected static Func<TRes, Func<TRes>, TRes> Unpack<I>() => (left, right) =>
        (TRes)Method.Default<I>(nameof(IBase<TRes>.Join)).Invoke(left, right);

    protected override TRes Fuse() {
        var link = new[] { (Prev as pulp<T, TRes>).LnkRight, LnkLeft }.Single(fn => fn is not null);
        return link(Prev.Yield(true), () => XForm(Seed));
    }
}