namespace Meas.Units.Base.Si.Accepted; //  Non-SI units accepted for use with SI)
public static class Base
{
    public readonly static Dictionary<string, string> NameAbbr = new() {
        { "minute", "m" },
        { "hour", "h" },
        { "day", "d" },
        { "astronomical unit", "au" },
        { "degree", "°" },
        { "arcminute", "′" },
        { "arcsedond", "″" },
        { "hectare", "ha" },
        { "litre", "l" },
        { "tonne", "t" },
        { "dalton", "Da" },
        { "electronVolt", "Ev" },
        { "neper", "Np" },
        { "", "" },
        { "bel", "B" }, // decibel Db
    };
}
