using FuncStore.Convers.RatioScale;
using MeasData.Calibration.Metric;
using Masses = MeasData.Calibration.Metric.Mass;
using Metric = MeasUnits.Prefixes.Metric;

namespace FuncStore.Convers.Tests.PhysMath;

[TestBy<Factoring<Metric.In>>]
[TestBy<Exponentiation<Metric.Exponent.In>>]
public class Accu_MetricTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<WholeNumbers, Masses>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) {
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
    }

    // ToDo: mismatch tests

    // ToDo: overflow tests

}