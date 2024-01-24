using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.RatioScale;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using Astro = Meas.Data.Length.Astro;
using Cross = Meas.Units.Phys.Distance.Length.Cross;
using Earth = Meas.Data.Length.Earth;
using Metric = Meas.Units.Prefix.Metric;

namespace FuncStore.Conversion.Tests.PhysMath.Dims;

[TestBy<Multiplication<Metric.In>>()]
[TestBy<Exponentiation<Metric.Exponent.In>>()]
[TestBy<Multiplication<Cross.SI_Customary.In>>()]
public class LengthsTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Earth.Distances, Earth.Elevations, Astro.Distances>()]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}
