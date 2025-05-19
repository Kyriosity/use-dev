using ISie.Number.Is.Mk.blocks;

namespace ISie.Number.Is.Menu.Options;
public interface IFloatPt<N, PS>
    where N : INumber<N> where PS : PolyStub<N>
{
    bool NaN { get; }
    bool Normal { get; }
    bool Subnormal { get; }
    bool Finite { get; }
    ZeroSide<N, PS> Infinity { get; }
}
