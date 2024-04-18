namespace MeasUnits.Phys.Distance.Length.Astro;

[Factored]
public enum In : long
{
    Undefined = 0,

    [Abbr("km")]
    Kilometer = -10,
    GigaKilometer = 100_000_000,

    [Abbr("LD")]
    LunarDistance = 38_440,

    LightSeconds = 29_979,
    LighMinute = 1_798_755,
    LigtYear = 946_053_000_000, // is light speed 299'792.5 x 31 556 925.9747 sec

    [Abbr("AU")]
    AstronomicalUnit = 14_959_787, // exactly 149,597,870,700 m.

    [Alias("parallax second")]
    [Abbr("pc")]
    Parsec = 3_085_700_000_000,
    [Abbr("kpc")]
    KiloParsec = 3_085_700_000_000_000,
    [Abbr("mpc")]
    MegaParsec = 3_085_700_000_000_000_000,
}