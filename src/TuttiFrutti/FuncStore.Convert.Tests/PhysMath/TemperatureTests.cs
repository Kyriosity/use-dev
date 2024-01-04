using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using Meas.Data.Setup.Attributes;
using Meas.Data.Temperature;
using FuncStores = FuncStore.Convert.Temperature;

namespace FuncStore.Convert.Tests.RatioScale;

[TestBy<FuncStores.Basic>]
[Precision(0.000_001)] // ToDo: prevent negative
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Theory, PhaseChange, Nature>]
    public override void Compare<N>((N val, TUnit unit) left, (N val, TUnit unit) right, double? delta,
        string name, string cat, string @class) {
        base.Compare(left, right, delta, name, cat, @class);
    }
}

