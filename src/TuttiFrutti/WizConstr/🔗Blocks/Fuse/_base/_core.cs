namespace WizConstr.Blocks.Fuse._base;

public abstract class _core<TSrc, TRes>(TSrc seed) : Blocks.Core<TSrc, TRes>(seed)
{
    protected virtual Type? FnLeft { get; } = null;
    protected virtual Type? FnRight { get; } = null;

    protected override TRes Yield() {
        throw new NotImplementedException(); // ToDo: VALUE by CHAIN
    }
}