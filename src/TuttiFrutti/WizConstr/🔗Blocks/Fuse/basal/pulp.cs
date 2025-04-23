namespace WizConstr.Blocks.Fuse.basal;

public abstract class pulp<TSrc, TRes> : Blocks.Pulp<TSrc, TRes>
{

    protected override TRes Yield() =>
        Prev is null ? Eval() :
            new[] { Prev.LnkRight, LnkLeft }.Single(fn => fn is not null)(Prev.Eval(), Eval());
}