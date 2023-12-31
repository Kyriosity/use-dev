using FuncStore.Convert.RatioScale;
using FuncStore.Convert.Tests.Setup.Steps;
using System.Numerics;
using Metric = Meas.Units.Prefix.Metric;
using TestData = Data.Setup.Metric;

namespace FuncStore.Convert.Tests.RatioScale;

[TestFixture(typeof(Multiplication<Metric.In>), typeof(Metric.In))]
[TestFixture(typeof(DecimalExponenting<Metric.Exponent.In>), typeof(Metric.Exponent.In))]
public class Accu_MetricTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestCaseSource(typeof(TestData.Samples.MathIntegral), nameof(TestData.Samples.MathIntegral.Based))]
    [TestCaseSource(typeof(TestData.Samples.MathIntegral), nameof(TestData.Samples.MathIntegral.Same))]
    [TestCaseSource(typeof(TestData.Samples.MathIntegral), nameof(TestData.Samples.MathIntegral.Cross))]

    [TestCaseSource(typeof(TestData.Phys.Weight), nameof(TestData.Phys.Weight.Calibres))]
    public void ConvertBackForth<N>((N val, TUnit unit) left, (N val, TUnit unit) right, string dir, string cat) where N : INumber<N> {

        Assert.Multiple(() => {
            ConvertBackForth<N>(left, right);
            ConvertBackForth<N>(right, left);
        });
    }

    // EXTREMES

    // ERRORS
}
