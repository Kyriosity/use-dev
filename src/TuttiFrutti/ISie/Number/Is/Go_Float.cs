using ISie.Number.Is.Menu.TypeBreak;
using ISie.Number.Is.Mk;

namespace ISie.Number.Is;
public static partial class Go
{
    extension(double seed)
    {
        public INavFloatPt<double, PolyStub<double>> Is => new IsFloatPt<double, PolyStub<double>, IOWire>(PolyStub.Of(seed));
        public INavFloatPt<double, PolyStub<double>> Not => new IsFloatPt<double, PolyStub<double>, IOInverter>(PolyStub.Of(seed));
    }

    extension(float seed)
    {
        public INavFloatPt<float, PolyStub<float>> Is => new IsFloatPt<float, PolyStub<float>, IOWire>(PolyStub.Of(seed));
        public INavFloatPt<float, PolyStub<float>> Not => new IsFloatPt<float, PolyStub<float>, IOInverter>(PolyStub.Of(seed));

    }

    // ToDesign: special case for decimal
    //extension(decimal seed)
    //{
    //    public INavFloatPt<decimal, PolyStub<decimal>> Is => NotImplemented.Throw("under dev");
    //}

}

