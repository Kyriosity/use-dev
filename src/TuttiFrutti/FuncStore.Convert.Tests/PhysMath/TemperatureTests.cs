using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using Meas.Data.Setup.Attributes;
using Meas.Data.Temperature;
using FuncStores = FuncStore.Convert.Temperature;

namespace FuncStore.Convert.Tests.RatioScale;

[TestBy<FuncStores.Basic>]
[Precision(.000_001)]
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Theory, PhaseChange, Nature>]
    public override void Convert<N>(N leftVal, TUnit leftUnit, N rightVal, TUnit rightUnit, string name, string cat, double? delta) {
        base.Convert(leftVal, leftUnit, rightVal, rightUnit, name, cat, delta);
    }
}

