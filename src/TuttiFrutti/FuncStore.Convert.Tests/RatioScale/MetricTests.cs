using FuncStore.Convert.RatioScale;
using System.Numerics;
using Measured = Meas.Units.Prefix.Metric;
using TestData = Data.Setup.Metric;

namespace FuncStore.Convert.Tests.RatioScale;

[TestFixture(typeof(Factoring<Measured.In>), typeof(Measured.In))]
[TestFixture(typeof(DecimalExponenting<Measured.Exponent.In>), typeof(Measured.Exponent.In))]
public class MetricTests<TStore, TUnit> : UnitsTestBedrock<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestCaseSource(typeof(TestData.Samples.MathIntegral), nameof(TestData.Samples.MathIntegral.Based))]
    [TestCaseSource(typeof(TestData.Samples.MathIntegral), nameof(TestData.Samples.MathIntegral.Same))]
    [TestCaseSource(typeof(TestData.Samples.MathIntegral), nameof(TestData.Samples.MathIntegral.Cross))]

    [TestCaseSource(typeof(TestData.Phys.Weight), nameof(TestData.Phys.Weight.Calibres))]
    public void ScaleBackForth<N>(N left, string from, string _, N right, string to) where N : INumber<N> {

        var units = Parse(out var unparsed, from, to);
        if (unparsed.Any())
            Assert.Ignore($"Couldn't parse: '{string.Join("', '", unparsed)}'");

        if (CheckConvert<N>((units[from], left), (units[to], right), out var res))
            CheckConvert<N>((units[to], res), (units[from], left), out var _);
    }

    // EXTREMES

    // ERRORS
}
