using Abc.Ext.NUnit.Metadata.Source;
using FuncStore.Conversion.RatioScale;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using MeasData.Digital;
using In = MeasUnits.Prefixes.Binary.Exponent.In;

namespace FuncStore.Conversion.Tests.Digital;

[TestBy<Factoring<In>>]
[TestBy<Exponentiation<In>>]
internal class BinaryPrefixedTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Calibration>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}
