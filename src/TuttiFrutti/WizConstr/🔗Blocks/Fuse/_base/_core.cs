namespace WizConstr.Blocks.Fuse._base;

public abstract class _core<TSrc, TRes>(TSrc seed) : Blocks.Core<TSrc, TRes>(seed)
{
    internal virtual Func<TRes, TRes, TRes>? LnkLeft { get; set; } = null;
    protected virtual Func<TRes, TRes, TRes>? LnkRight => null;

    protected override TRes Yield() =>
        Prev is null ? Eval() :
            new[] { LnkLeft, LnkRight }.Single(fn => fn is not null)(Eval(), Prev.Eval());
}
