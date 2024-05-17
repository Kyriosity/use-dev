using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static IModern Common =>
        new YearCentiEra(Scale.CommonEra);
    public static ILong BeforeCommon =>
        new YearCentiMilleEra(Scale.BeforeCommonEra);
    public static IEpochRuler Holocene =>
        new ShortEra(Scale.HoloceneEra);
}
