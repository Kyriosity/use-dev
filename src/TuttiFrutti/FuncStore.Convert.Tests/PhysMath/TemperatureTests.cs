using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using Meas.Data.Temperature;
using System.Numerics;

namespace FuncStore.Convert.Tests.RatioScale;

[TestBy<FuncStore.Convert.Temperature.Basic>()] // ToDecide: arguments may parametrize FuncStore
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Theory, Nature, PhaseChange>()] // ToDecide: arguments may filter and fine-tune test data
    public void Approve<N>((N val, TUnit unit) left, (N val, TUnit unit) right, string name, string cat, string @class) where N : INumber<N> {
        var typFactoryTestCase = typeof(TStore).Name;
        var typInTestCase = typeof(TUnit).FullName;

        ConvertBackForth(left, right);

        // Assert call 
    }
}