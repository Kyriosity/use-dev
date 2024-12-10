using FuncStore.Convers.RatioScale;
using MeasData.Length.Earth.Distances;
using MeasData.Length.Earth.Elevations;
using Cross = MeasUnits.Phys.Distance.Length.Cross.SI_Customary;
using Metric = MeasUnits.Prefixes.Metric;

namespace FuncStore.Convers.Tests.PhysMath.Dims;

[TestBy<Factoring<Metric.In>>]
[TestBy<Exponentiation<Metric.Exponent.In>>]
[TestBy<Factoring<Cross.In>>]
public class LengthsTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Distances, Elevations, MeasData.Length.Astro.Distances.Distances>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}
