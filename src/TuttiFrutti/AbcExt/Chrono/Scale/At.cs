namespace AbcExt.Chrono.Scale;
public enum At
{
    Undefined = 0,

    // popular
    CommonEra, // aka A.D.
    BeforeCommonEra, // aka B.C.
    HoloceneEra, // aka Human Era, HE

    // historic calendars
    AssyrianCalendar,
    ByzantineCalendar,
    MayaCalendar,
    SeleucidEra,
    ZoroastrianCalendar,

    // Earth
    EarthHistory, // ca.  4.54 billion years
    ModernHumans, // ca. 300`000

    UnixTime, // counts ± to the leap of 31/12/1969<->01/01/1970

    // cosmological/Universe
    Universe,

    // futuristic calendats
}
