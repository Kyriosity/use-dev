using WizConstr.Blocks.Fuse;

namespace WizConstr.Xform;

public abstract class Core<T, TRes> : Core<T>
{
    protected internal Func<TRes, TRes> Circuitry { get; set; }

    protected TPulp Next<TPulp>(Func<T, TRes> xform) // ToDesign: consolidate all Next()ies
        where TPulp : Pulp<T, TRes>,
            new() => new() { Seed = Seed, XForm = xform, Circuitry = Circuitry };

    protected Fruit<T, TRes> Next(Func<T, TRes> xform) => new() { XForm = xform, Seed = Seed, Circuitry = Circuitry };
}