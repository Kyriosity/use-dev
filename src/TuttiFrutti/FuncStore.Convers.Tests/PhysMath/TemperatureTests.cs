using MeasUnits.Phys.Temperature.KCF;
using Constants = MeasData.Temperature.Constants.Constants;
using FuncStores = FuncStore.Convers.Temperature;
using Nature = MeasData.Temperature.Nature.Nature;
using PhaseChange = MeasData.Temperature.PhaseChange.PhaseChange;

namespace FuncStore.Convers.Tests.PhysMath;

[TestBy<FuncStores.Basic<In>>]

public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Constants, PhaseChange, Nature>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}