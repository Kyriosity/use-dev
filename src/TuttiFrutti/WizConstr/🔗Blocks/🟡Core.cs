namespace WizConstr.Blocks;

public abstract class Core<TSrc, TRes> : Xform.Core<TSrc, TRes>
{
    public Core(TSrc seed) { Seed = seed; }
    protected Core<TSrc, TRes>? Prev { get; init; }
    public virtual TBk Next<TBk>() where TBk : Core<TSrc, TRes>, new()
        => new() { Seed = Seed, Prev = this };
}