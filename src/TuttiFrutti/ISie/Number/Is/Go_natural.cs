using ISie.Number.Is.Menu.TypeBreak;
using ISie.Number.Is.Mk;

namespace ISie.Number.Is;
public static partial class Go // unsigned
{
    extension(byte seed)
    {
        public INavNatural Is => new IsNatural<byte, PolyStub<byte>, IOWire>(PolyStub.Of(seed));
        public INavNatural Not => new IsNatural<byte, PolyStub<byte>, IOInverter>(PolyStub.Of(seed));
    }

    extension(ushort seed)
    {
        public INavNatural Is => new IsNatural<ushort, PolyStub<ushort>, IOWire>(PolyStub.Of(seed));
        public INavNatural Not => new IsNatural<ushort, PolyStub<ushort>, IOInverter>(PolyStub.Of(seed));
    }

    extension(uint seed)
    {
        public INavNatural Is => new IsNatural<uint, PolyStub<uint>, IOWire>(PolyStub.Of(seed));
        public INavNatural Not => new IsNatural<uint, PolyStub<uint>, IOInverter>(PolyStub.Of(seed));
    }

    extension(ulong seed)
    {
        public INavNatural Is => new IsNatural<ulong, PolyStub<ulong>, IOWire>(PolyStub.Of(seed));
        public INavNatural Not => new IsNatural<ulong, PolyStub<ulong>, IOInverter>(PolyStub.Of(seed));
    }
}
