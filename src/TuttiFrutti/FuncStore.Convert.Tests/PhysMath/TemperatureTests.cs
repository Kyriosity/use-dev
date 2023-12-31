using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using Meas.Data.Temperature;
using System.Numerics;

namespace FuncStore.Convert.Tests.RatioScale;

[TestBy<FuncStore.Convert.Temperature.Basic>()] // Options: IGNORE UNPARSED, SKIP
public class TemperatureTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum, IConvertible
{
    [TestOf<Theory, Nature, PhaseChange>("limit: 3", "ROUND: 0.00", "type: int", "LINQ: Where(C > 0)")] // All
    public void Approve<N>((N val, TUnit unit) left, (N val, TUnit unit) right, string name, string cat, string @class) where N : INumber<N> {
        var typFactoryTestCase = typeof(TStore).Name;
        var typInTestCase = typeof(TUnit).FullName;

        ConvertBackForth(left, right);
    }
}