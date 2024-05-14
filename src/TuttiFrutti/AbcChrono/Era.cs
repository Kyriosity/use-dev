using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static IModern Common =>
        new YearCentiEra();
    public static ILong BeforeCommon =>
        new YearCentiMilleEra();
    public static IShort Holocene =>
        new ShortEra();
}
