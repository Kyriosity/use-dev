namespace WizConstr.Blocks.Fuse._base;

public abstract class _core<TSrc, TRes>(TSrc seed) : Blocks.Core<TSrc, TRes>(seed)
{
    internal virtual Type? LnkLeft { get; set; } = null;
    protected virtual Type? LnkRight { get; } = null;

    protected override TRes Yield() {
        if (Prev is null)
            return Eval();

        throw new NotImplementedException();
    }
}
