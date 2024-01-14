using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using Meas.Data.Setup.Attributes;
using Meas.Data.Temperature;
using FuncStores = FuncStore.Conversion.Temperature;

namespace FuncStore.Conversion.Tests.RatioScale;

[TestBy<FuncStores.Basic>]
[Precision(.000_001)]
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Constants, PhaseChange, Nature>]
    public override void Match<N>(N leftVal, TUnit leftUnit, N rightVal, TUnit rightUnit, string name, string cat, double? delta) {
        base.Match(leftVal, leftUnit, rightVal, rightUnit, name, cat, delta);
    }
}

