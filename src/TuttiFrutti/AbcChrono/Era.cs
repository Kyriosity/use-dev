using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static IModern<IYearX1WithCurrent> Common =>
        new YearCentiEra<IYearX1WithCurrent>(On.CommonEra);
    public static ILong<IYearX1> BeforeCommon =>
        new YearCentiMilleEra<IYearX1>(On.BeforeCommonEra);
    public static IEpochRuler Holocene =>
        new ShortEra(On.HoloceneEra);
}
