using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using Meas.Data.Temperature;

namespace FuncStore.Convert.Tests.RatioScale;

[TestBy<FuncStore.Convert.Temperature.Basic>()]
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{

    [TestOf<Theory, PhaseChange>]
    [TestOf<Nature>]
    public override void Compare<N>((N val, TUnit unit) left, (N val, TUnit unit) right, string name, string cat, string @class) {
        base.Compare(left, right, name, cat, @class);
    }
}

