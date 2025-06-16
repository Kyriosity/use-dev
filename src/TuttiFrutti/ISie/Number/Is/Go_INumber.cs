using ISie.Number.Is.Menu.TypeBreak;
using ISie.Number.Is.Mk;

namespace ISie.Number.Is;

public static partial class Go // unsigned
{
    extension<N>(N seed) where N : INumber<N>
    {
        public INavFloatPt<N, PolyStub<N>> Is => new IsFloatPt<N, PolyStub<N>, IOWire>(PolyStub.Of(seed));
        public INavFloatPt<N, PolyStub<N>> Not => new IsFloatPt<N, PolyStub<N>, IOInverter>(PolyStub.Of(seed));
    }
}
