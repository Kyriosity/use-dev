using ISie.Number.Is.Menu.TypeBreak;

namespace ISie.Number.Is;

public static partial class Go // +/- integral
{
    extension(sbyte seed)
    {
        public INavIntegral<sbyte, PolyStub<sbyte>> Is => new IsIntegral<sbyte, PolyStub<sbyte>, IOWire>(PolyStub.Of(seed));
        public INavIntegral<sbyte, PolyStub<sbyte>> Not => new IsIntegral<sbyte, PolyStub<sbyte>, IOInverter>(PolyStub.Of(seed));
    }


    extension(short seed)
    {
        //public INavIntegral<short, PolyStub<short>> Is => new IsIntegral<short, PolyStub<short>, IOWire>(PolyStub.Of(seed));
        //public INavIntegral<short, PolyStub<short>> Not => new IsIntegral<short, PolyStub<short>, IOInverter>(PolyStub.Of(seed));

    }

    extension(int seed)
    {
        public INavIntegral<int, PolyStub<int>> Is => new IsIntegral<int, PolyStub<int>, IOWire>(PolyStub.Of(seed));
        public INavIntegral<int, PolyStub<int>> Not => new IsIntegral<int, PolyStub<int>, IOInverter>(PolyStub.Of(seed));

    }

    extension(long seed)
    {

    }
}