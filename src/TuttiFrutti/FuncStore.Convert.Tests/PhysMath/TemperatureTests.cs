using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using Meas.Data.Temperature;
using FuncStores = FuncStore.Conversion.Temperature;

namespace FuncStore.Conversion.Tests.RatioScale;

[TestBy<FuncStores.Basic<Meas.Units.Phys.Temperature.KCF.In>>]

public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Constants, PhaseChange, Nature>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}