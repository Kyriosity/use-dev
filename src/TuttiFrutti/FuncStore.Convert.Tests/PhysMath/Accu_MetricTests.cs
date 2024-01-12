using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Convert.RatioScale;
using FuncStore.Convert.Tests.Setup.Metadata;
using FuncStore.Convert.Tests.Setup.Steps;
using Meas.Data.Calibration.Metric;
using Meas.Data.Setup.Attributes;
using Metric = Meas.Units.Prefix.Metric;

namespace FuncStore.Convert.Tests.RatioScale;

[TestBy<Multiplication<Metric.In>>()]
[TestBy<DecimalExponenting<Metric.Exponent.In>>()]

[Precision(.000_000_1)]
public class Accu_MetricTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<MathIntegral>]
    public override void Match<N>(N subject, TUnit subjUnit, N expected, TUnit expUnit, string name, string cat, double? delta) {
        base.Match(subject, subjUnit, expected, expUnit, name, cat, delta);
    }

    // ToDo: mismatch tests

    // ToDo: overflow tests

}