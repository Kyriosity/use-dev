using ISie.Number.Is.Menu.Options;
using ISie.Number.Is.Mk.blocks;

namespace ISie.Number.Is.Menu.TypeBreak;
public interface INavFloatPt<N, PS> : IFloatPt<N, PS>
    where N : INumber<N> where PS : PolyStub<N>
{
    Integral<N, PS> Integer { get; }
    Natural<N, PS> NaturalOr0 { get; }
}