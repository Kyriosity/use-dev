using FuncStore.Convers.RatioScale;
using Forces = MeasData.Mech.Force.Dirs;
using Units = MeasUnits.Phys.Mech.Force;

namespace FuncStore.Convers.Tests.PhysMath.Mech;

[TestBy<Factoring<Units.In>>]
[TestBy<Factoring<Units.SI.In>>]
[TestBy<Factoring<Units.UsCustomary.In>>]
public class ForcesTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
      where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [Test<Forces>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}