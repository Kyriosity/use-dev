using WizConstr.Xform;

namespace WizConstr.Blocks.Fuse;

public abstract class Root<TSrc, TRes>
{
    public static TCore Plant<TCore>(TSrc seed) where TCore : Core<TSrc>, INoLnkLeft, new() {
        // ToDesign: propagate CIRCUITRY
        return new TCore { Seed = seed };
    }

    public static TFruit Plant<TFruit>(TSrc seed, Func<TSrc, TRes> xform) where TFruit : Core<TSrc>, IXFormFunction<TSrc, TRes>, new() {
        return new TFruit { Seed = seed, Xform = xform };
    }
}