using AbcChrono.Timescales.Sol3.Era;
using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales;
public class Era
{
    public static IModern<IYearX1WithCurrent> Common =>
        new YearCentiEra<IYearX1WithCurrent>(On.CommonEra);
    public static ILong<IYearX1> BeforeCommon =>
        new YearCentiMilleEra<IYearX1>(On.BeforeCommonEra);
    public static IEpochRuler Holocene =>
        new ShortEra(On.HoloceneEra);
}
