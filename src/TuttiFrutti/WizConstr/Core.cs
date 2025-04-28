using WizConstr.Blocks;

namespace WizConstr;

public abstract class Core<T>
{
    protected internal T? Seed { get; init; }

    protected TCore Next<TCore>()
        where TCore : Core<T>, INoLnkLeft,
            new() => new TCore { Seed = Seed };
    // ToDesign: propagate to DESCENDANTS !
    // ToDesign: propagate CIRCUITRY 

    protected TPulp Next<TRes, TPulp>(Func<T, TRes> xform)
        where TPulp : Xform.Pulp<T, TRes>,
            new() => new() { Seed = Seed, XForm = xform };
}

public abstract class Core<T, TRes> : Core<T>
{
    protected TPulp Next<TPulp>(Func<T, TRes> xform)
        where TPulp : Xform.Pulp<T, TRes>,
            new() => new() { Seed = Seed, XForm = xform };
}