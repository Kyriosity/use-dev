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
        public INavNatural Is => NotImplemented.Throw("under dev");
    }

    extension(uint seed)
    {
        public INavNatural Is => NotImplemented.Throw("under dev");
    }

    extension(ulong seed)
    {
        public INavNatural Is => NotImplemented.Throw("under dev");
    }
}
