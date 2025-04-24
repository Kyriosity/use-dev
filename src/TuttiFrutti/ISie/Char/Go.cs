using ISie.Char.Is.Menus;

namespace ISie.Char;
public static class Go
{
    public static IRoot Is(this char seed) => null;
    public static To.IMenu To(this char seed) => new To.Menu(seed);
}
