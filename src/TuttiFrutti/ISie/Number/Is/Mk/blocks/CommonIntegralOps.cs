using ISie.Number.Is.Menu.Options;

namespace ISie.Number.Is.Mk.blocks;
public abstract class CommonIntegralOps<N, PS, IO>(PS seed) : Root<N, PS, IO>(seed), IIntegral
    where N : INumber<N> where PS : PolyStub<N> where IO : Circuitry.IO
{
    public bool Odd => Next(seed => N.IsOddInteger(seed.Value));

    public bool Even => Next(seed => N.IsEvenInteger(seed.Value));
}