using FuncStore.Convers.RatioScale;
using MeasData.Digital;
using Binary = MeasUnits.Prefixes.Binary;

namespace FuncStore.Convers.Tests.Digital;

[TestBy<Factoring<Binary.In>>]
[TestBy<Exponentiation<Binary.Exponent.In>>]
public class BinaryPrefixedTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Calibration>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}
