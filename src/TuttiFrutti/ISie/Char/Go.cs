using AbcStoppers.Errors.Sys;
using ISie.Char.Is.Menus;

namespace ISie.Char;
public static class Go
{
    public static IFull Is(this char seed) => new AllInclusive(seed);
    public static IFull Is(this char? seed) => seed is null ? ArgumentNull.Throw(err_hint) : Is((char)seed);
    public static To.IMenu To(this char seed) => new To.Menu(seed);
    public static To.IMenu To(this char? seed) => seed is null ? ArgumentNull.Throw(err_hint) : To((char)seed);

    private const string err_hint = "You must check for null!";
}
