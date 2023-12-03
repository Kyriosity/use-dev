using FuncStore.Convert.RatioScale;
using System.Numerics;
using Metric = Meas.Units.Prefix.Metric;
using TestData = Data.Setup.Samples.Metric;

namespace FuncStore.Convert.Tests.RatioScale;

[TestFixture(typeof(Factoring<Metric.In>), typeof(Metric.In))]
[TestFixture(typeof(DecimalExponenting<Metric.Exponent.In>), typeof(Metric.Exponent.In))]
public class MetricTests<TStore, TUnit> : UnitsTestBedrock<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestCaseSource(typeof(TestData.WholeNumbers.Multitype), nameof(TestData.WholeNumbers.Multitype.Based))]
    [TestCaseSource(typeof(TestData.WholeNumbers.Multitype), nameof(TestData.WholeNumbers.Multitype.Same))]
    [TestCaseSource(typeof(TestData.WholeNumbers.Multitype), nameof(TestData.WholeNumbers.Multitype.Cross))]
    public void ScaleBackForth<N>(N left, string from, string predicate, N right, string to) where N : INumber<N> {

        var units = Parse(out var unparsed, from, to);
        if (unparsed.Any())
            Assert.Ignore($"Couldn't parse: '{string.Join("', '", unparsed)}'");

        if (CheckConvert<N>((units[from], left), (units[to], right), out var res))
            CheckConvert<N>((units[to], res), (units[from], left), out var _);
    }

    // EXTREMES

    // ERRORS
}
