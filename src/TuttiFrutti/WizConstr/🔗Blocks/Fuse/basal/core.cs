namespace WizConstr.Blocks.Fuse.basal;

public abstract class core<TSrc, TRes> : Blocks.Core<TSrc, TRes>
{

    protected override TRes Yield() =>
        Prev is null ? Eval() :
            new[] { Prev.LnkRight, LnkLeft }.Single(fn => fn is not null)(Eval(), Prev.Eval());
}
