namespace Meas.Units.Names.Si.Accepted; //  Non-SI units accepted for use with SI)
public static class Base
{
    public readonly static Dictionary<string, string> NameAbbr = new(StringComparer.InvariantCultureIgnoreCase) {
        { "minute", "m" },
        { "hour", "h" },
        { "day", "d" },
        { "astronomical unit", "au" },
        { "degree", "°" },
        { "arcminute", "′" },
        { "arcsedond", "″" },
        { "hectare", "ha" },
        { "litre", "l" },
        { "dalton", "Da" },
        { "electronVolt", "Ev" },
        { "neper", "Np" },
        { "bel", "B" }, // decibel Db
    };
}
