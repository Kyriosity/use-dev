using AbcChrono.Sol3.Calendar;

namespace AbcChrono;
public class Era
{
    public static ITimes Common =>
        new YearCentiEra();
    public static IEra BeforeCommon =>
        new YearCentiMilleEra();
    public static ITimes Holocene =>
        new YearCentiEra();
}
