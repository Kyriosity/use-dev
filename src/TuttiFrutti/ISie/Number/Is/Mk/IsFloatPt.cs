using ISie.Number.Is.Menu.TypeBreak;
using ISie.Number.Is.Mk.blocks;

namespace ISie.Number.Is.Mk;
public class IsFloatPt<N, PS, IO>(PS seed) : Root<N, PS, IO>(seed), INavFloatPt<N, PS>
    where N : INumber<N> where PS : PolyStub<N> where IO : Circuitry.IO
{
    public Integral<N, PS> Integer => Next<Integral<N, PS>>(n => N.IsInteger(n.Value));

    public Natural<N, PS> NaturalOr0 => Next<Natural<N, PS>>(n => n.IsNaturalOr0());

    public bool NaN => Next(seed => seed.IsNaN());

    public bool Normal => Next(seed => N.IsNormal(seed.Value));

    public bool Subnormal => N.IsSubnormal(seed.Value);

    public bool Finite => Next(seed => N.IsFinite(seed.Value));

    public ZeroSide<N, PS> Infinity => Next<ZeroSide<N, PS>>(n => N.IsInfinity(seed.Value));
}
