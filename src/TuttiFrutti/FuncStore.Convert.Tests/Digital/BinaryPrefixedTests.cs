using FuncStore.Conversion.RatioScale;
using FuncStore.Conversion.Tests.Setup.Metadata;
using FuncStore.Conversion.Tests.Setup.Steps;
using MeasData.Digital;
using Bin = MeasUnits.Prefixes.Binary;

namespace FuncStore.Conversion.Tests.Digital;

[TestBy<Factoring<Bin.In>>]
[TestBy<Exponentiation<Bin.Exponent.In>>]
internal class BinaryPrefixedTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Calibration>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}
