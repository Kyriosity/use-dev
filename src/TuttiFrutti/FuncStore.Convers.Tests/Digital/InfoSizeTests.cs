using FuncStore.Convers.RatioScale;
using MeasUnits.Digital;
using Sizes = MeasData.Digital.Size.Size; // ToDo: REMOVE DOUBLE ! (Rearrange: Size.Size)

namespace FuncStore.Convers.Tests.Digital;

[TestBy<Factoring<In>>]
public class InfoSizeTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    [TestOf<Sizes>]
    public override void Match<N>(N valA, TUnit unitA, N valB, TUnit unitB, string title, string cat, double? delta) =>
        base.Match(valA, unitA, valB, unitB, title, cat, delta);
}