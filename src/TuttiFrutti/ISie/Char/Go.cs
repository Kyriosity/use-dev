using Abc.Logic.Circuitry.Bool;
using ISie.Char.Is.Menus;

namespace ISie.Char;
public static class Go
{
    public static IFull Is(this char seed) => new AllInclusive<IOWire>(seed);
    public static IFull Not(this char seed) => new AllInclusive<IOInverter>(seed);
    public static IFull Is(this char? seed) => seed is null ? ArgumentNull.Throw(err_hint) : Is((char)seed);
    public static IFull Not(this char? seed) => seed is null ? ArgumentNull.Throw(err_hint) : Not((char)seed);
    public static To.IMenu To(this char seed) => new To.Menu(seed);
    public static To.IMenu To(this char? seed) => seed is null ? ArgumentNull.Throw(err_hint) : To((char)seed);

    private const string err_hint = "No check for null done!";
}
