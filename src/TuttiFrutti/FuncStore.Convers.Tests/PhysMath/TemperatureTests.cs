using Constants = MeasData.Temperature.Constants.Constants;
using Funcs = FuncStore.Convers.Temperature;
using Nature = MeasData.Temperature.Nature.Nature; // ToDo: remove double!
using PhaseChange = MeasData.Temperature.PhaseChange.PhaseChange;
using Trio = MeasUnits.Phys.Temperature.KCF;

namespace FuncStore.Convers.Tests.PhysMath;

[TestBy<Funcs.Basic<Trio.In>>]
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Constants, PhaseChange, Nature>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}