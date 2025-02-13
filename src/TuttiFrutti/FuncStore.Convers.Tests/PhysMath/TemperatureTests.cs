using Constants = MeasData.Temperature.Constants.Dirs;
using Funcs = FuncStore.Convers.Temperature;
using Nature = MeasData.Temperature.Nature.Dirs;
using PhaseChanges = MeasData.Temperature.PhaseChange.Dirs;
using Trio = MeasUnits.Phys.Temperature.KCF;

namespace FuncStore.Convers.Tests.PhysMath;

[TestBy<Funcs.Basic<Trio.In>>]
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [Test<Constants, PhaseChanges, Nature>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}