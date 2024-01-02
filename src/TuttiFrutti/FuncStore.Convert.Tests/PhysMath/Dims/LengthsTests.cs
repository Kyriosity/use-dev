using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.RatioScale;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using System.Numerics;
using Astro = Meas.Data.Length.Astro;
using Cross = Meas.Units.Phys.Distance.Length.Cross;
using Earth = Meas.Data.Length.Earth;
using Metric = Meas.Units.Prefix.Metric;


namespace FuncStore.Convert.Tests.PhysMath.Dims;

[TestBy<Multiplication<Metric.In>>()]
[TestBy<DecimalExponenting<Metric.Exponent.In>>()]
[TestBy<Multiplication<Cross.SI_Customary.In>>()]
public class LengthsTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{

    [TestOf<Earth.Distances, Earth.Elevations>()]
    public void Approve<N>((N val, TUnit unit) left, (N val, TUnit unit) right, string name, string cat, string @class) where N : INumber<N> {

    }

    // SEPARATE TESTS !!!
    [TestOf<Astro.Distances>()]
    public void BigNumbers<N>((N val, TUnit unit) left, (N val, TUnit unit) right, string name, string cat, string @class) where N : INumber<N> {

    }

}
