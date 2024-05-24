using AbcChrono.Sol3.Era;

namespace AbcChrono;
public class Era
{
    public static IModern Common =>
        new YearCentiEra(At.CommonEra);
    public static ILong BeforeCommon =>
        new YearCentiMilleEra(At.BeforeCommonEra);
    public static IEpochRuler Holocene =>
        new ShortEra(At.HoloceneEra);
}
