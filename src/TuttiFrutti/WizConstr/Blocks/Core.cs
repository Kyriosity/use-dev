namespace WizConstr.Blocks;

public abstract class Core<TSrc, TRes> : Nav.Core<TSrc, TRes>
{
    public Core(TSrc seed) { Seed = seed; }
}


public abstract class Fruit<TSrc, TRes> : Core<TSrc, TRes>
{
    internal Fruit(TSrc seed) : base(seed) { }

    public static implicit operator TRes(Fruit<TSrc, TRes> source) => source.Yield();
}
