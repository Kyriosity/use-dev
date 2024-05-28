using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static IModern Common =>
        new YearCentiEra(On.CommonEra);
    public static ILong BeforeCommon =>
        new YearCentiMilleEra(On.BeforeCommonEra);
    public static IEpochRuler Holocene =>
        new ShortEra(On.HoloceneEra);
}
