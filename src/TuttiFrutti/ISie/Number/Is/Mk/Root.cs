namespace ISie.Number.Is.Mk;
public abstract class Root<N, PS, IO>(PS seed) : Root<PS, IO>(seed)
    where N : INumber<N> where PS : PolyStub<N> where IO : Circuitry.IO;