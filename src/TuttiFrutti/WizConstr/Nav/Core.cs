namespace WizConstr.Nav;

public abstract class Core<TSrc, TRes> : Xform.Core<TSrc, TRes>
{
    protected abstract Core<TSrc, TRes> Prev { get; init; }
    internal virtual NXT Next<NXT>() where NXT : Core<TSrc, TRes>, new()
        => new NXT { Seed = Seed, Prev = this };
}
