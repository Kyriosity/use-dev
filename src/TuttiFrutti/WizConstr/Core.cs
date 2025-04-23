using WizConstr.Blocks;
using WizConstr.Xform;

namespace WizConstr;

public abstract class Core<T>
{
    protected internal T? Seed { get; init; }

    protected TCore Next<TCore>() where TCore : Core<T>, INoLnkLeft, new() {
        // ToDesign: MUST BE USED in DESCENDANTS !
        // ToDesign: propagate CIRCUITRY
        return new TCore { Seed = Seed };
    }

    protected TFruit Next<TRes, TFruit>(Func<T, TRes> xform)

        where TFruit : Core<T>, IXFormFuncd<T, TRes>, new() {

        return new TFruit { Seed = Seed, Xform = xform };
    }
}

public abstract class Core<T, TRes> : Core<T>
{
    protected TFruit Next<TFruit>(Func<T, TRes> xform)

        where TFruit : Core<T>, IXFormFuncd<T, TRes>, new() {

        return new TFruit { Seed = Seed, Xform = xform };
    }
}