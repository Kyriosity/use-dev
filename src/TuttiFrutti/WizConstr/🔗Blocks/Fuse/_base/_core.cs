namespace WizConstr.Blocks.Fuse._base;

public abstract class _core<TSrc, TRes> : Blocks.Core<TSrc, TRes>
{

    protected override TRes Yield() =>
        Prev is null ? Eval() :
            new[] { Prev.LnkRight, LnkLeft }.Single(fn => fn is not null)(Eval(), Prev.Eval());
}
