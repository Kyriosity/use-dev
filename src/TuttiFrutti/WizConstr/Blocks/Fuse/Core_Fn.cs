using WizConstr.Blocks.Fuse;

namespace WizConstr.Blocks.Joint;

public abstract class Core_Fn<TSrc, TRes, TFn>(TSrc seed) : Core<TSrc, TRes>(seed), ILeftVoid, IApplyRight
    where TFn : boolFn.IBase<TRes>
{
    internal new NXT Next<NXT>() where NXT : IApplyLeft, new() {
        return new NXT(); //return base.Next<TSrc>();
    }
}


public abstract class Core_Fn<TSrc, TFn>(TSrc seed) : Core_Fn<TSrc, bool, TFn>(seed) where TFn : boolFn.IBool;

public abstract class Fruit_Fn<TSrc, TFn>(TSrc seed) : Core_Fn<TSrc, TFn>(seed) where TFn : boolFn.IBool
{
    public static implicit operator bool(Fruit_Fn<TSrc, TFn> source) => source.Yield();
}

public abstract class Core_Or<TSrc>(TSrc seed) : Core_Fn<TSrc, boolFn.IDisjunct>(seed);

public abstract class Core_And<TSrc>(TSrc seed) : Core_Fn<TSrc, boolFn.IConjunct>(seed);

public abstract class Core_Xor<TSrc>(TSrc seed) : Core_Fn<TSrc, boolFn.IExclude>(seed);