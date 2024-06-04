using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static IModern<IAnnualCurrent> Common =>
        new YearCentiEra<IAnnualCurrent>(On.CommonEra);
    public static ILong<IAnnual> BeforeCommon =>
        new YearCentiMilleEra<IAnnual>(On.BeforeCommonEra);
    public static IEpochRuler Holocene =>
        new ShortEra(On.HoloceneEra);
}
