using FuncStore.Convers.RatioScale;
using MeasData.Mech.Force;

namespace FuncStore.Convers.Tests.PhysMath.Mech;

[TestBy<Factoring<MeasUnits.Phys.Mech.Force.In>>]
public class ForcesTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
      where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Forces>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}