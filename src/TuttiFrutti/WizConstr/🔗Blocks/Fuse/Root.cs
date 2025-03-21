using WizConstr.Xform;

namespace WizConstr.Blocks.Fuse;

public interface Root<T>
{
    static TCore Plant<TCore>(T seed) where TCore : Core<T>, INoLnkLeft, new() {
        // ToDesign: propagate CIRCUITRY
        return new TCore { Seed = seed };
    }

    static TFruit Plant<TFruit, TRes>(T seed, Func<T, TRes> xform) where TFruit : Core<T>, IXFormSet<T, TRes>, new() {
        return new TFruit { Seed = seed, Xform = xform };
    }
}