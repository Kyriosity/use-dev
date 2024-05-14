using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static ILarge Common =>
        new YearCentiEra();
    public static ISmall BeforeCommon =>
        new YearCentiMilleEra();
    public static ILarge Holocene =>
        new YearCentiEra();
}
