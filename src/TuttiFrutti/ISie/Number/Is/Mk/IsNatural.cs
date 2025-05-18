using ISie.Number.Is.Menu.TypeBreak;

namespace ISie.Number.Is.Mk;
public class IsNatural<N, PS, IO>(PS seed) : CommonIntegralOps<N, PS, IO>(seed), INavNatural
    where N : INumber<N> where PS : PolyStub<N> where IO : Circuitry.IO
{
    public bool PowOf2 => Next(seed => seed.IsPow2());
}
