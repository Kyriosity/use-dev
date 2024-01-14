using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.RatioScale;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using Meas.Data.Calibration.Metric;
using Meas.Data.Setup.Attributes;
using Metric = Meas.Units.Prefix.Metric;

namespace FuncStore.Conversion.Tests.RatioScale;

[TestBy<Multiplication<Metric.In>>()]
[TestBy<Exponentiation<Metric.Exponent.In>>()]

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