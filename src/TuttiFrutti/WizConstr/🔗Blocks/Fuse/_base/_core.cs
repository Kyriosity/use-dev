using AbcRefl.Implementation;

namespace WizConstr.Blocks.Fuse._base;

public abstract class _core<TSrc, TRes> : Blocks.Core<TSrc, TRes>
{
    internal virtual Func<TRes, TRes, TRes>? LnkLeft { get; set; } = null;
    protected virtual Func<TRes, TRes, TRes>? LnkRight => null;

    protected override TRes Yield() =>
        Prev is null ? Eval() :
            new[] { LnkLeft, LnkRight }.Single(fn => fn is not null)(Eval(), Prev.Eval());

    protected static Func<TRes, TRes, TRes> Unpack<I>() =>
        (argL, argR) => (TRes)Method.Default<I>(nameof(fuseFn.IBase<TRes>.Join)).Invoke(argL, argR);
}
