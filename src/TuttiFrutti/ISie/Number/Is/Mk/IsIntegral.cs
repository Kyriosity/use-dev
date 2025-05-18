using ISie.Number.Is.Menu.TypeBreak;
using ISie.Number.Is.Mk;

public class IsIntegral<N, PS, IO>(PS seed) : CommonIntegralOps<N, PS, IO>(seed), INavIntegral<N, PS>
    where N : INumber<N> where PS : PolyStub<N> where IO : Circuitry.IO
{
    public Natural<N, PS> NaturalOr0 => Next<Natural<N, PS>>(n => n.IsNaturalOr0());
}