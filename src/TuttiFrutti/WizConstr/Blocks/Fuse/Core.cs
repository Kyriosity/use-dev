namespace WizConstr.Blocks.Fuse;

public abstract class Core<TSrc, TRes>(TSrc seed) : Blocks.Core<TSrc, TRes>(seed), ILeftVoid, IRightVoid
{
    internal new NXT Next<NXT>() where NXT : IApplyLeft, new() {
        return new NXT(); //return base.Next<TSrc>();
    }
}

