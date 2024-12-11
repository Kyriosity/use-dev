using FuncStore.Convers.RatioScale;
using Astro = MeasData.Length.Astro.Distances.Dirs;
using Cross = MeasUnits.Phys.Distance.Length.Cross.SI_Customary;
using Distances = MeasData.Length.Earth.Distances.Dirs;
using Elevations = MeasData.Length.Earth.Elevations.Dirs;
using Metric = MeasUnits.Prefixes.Metric;

namespace FuncStore.Convers.Tests.PhysMath.Dims;

[TestBy<Factoring<Metric.In>>]
[TestBy<Exponentiation<Metric.Exponent.In>>]
[TestBy<Factoring<Cross.In>>]
public class LengthsTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Distances, Elevations, Astro>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}