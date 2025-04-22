using WizConstr.Blocks;
using WizConstr.Xform;

namespace WizConstr;

public abstract class Core<T>
{
    protected internal T? Seed { get; init; }

    public static TCore Next<TCore>(T seed) where TCore : Core<T>, INoLnkLeft, new() {
        // ToDesign: propagate CIRCUITRY
        return new TCore { Seed = seed };
    }

    public static TFruit Next<TRes, TFruit>(T seed, Func<T, TRes> xform)

        where TFruit : Core<T>, IXFormFunction<T, TRes>, new() {

        return new TFruit { Seed = seed, Xform = xform };
    }
}

public abstract class Core<T, TRes> : Core<T>
{
    public static TFruit Next<TFruit>(T seed, Func<T, TRes> xform)

        where TFruit : Core<T>, IXFormFunction<T, TRes>, new() {

        return new TFruit { Seed = seed, Xform = xform };
    }
}