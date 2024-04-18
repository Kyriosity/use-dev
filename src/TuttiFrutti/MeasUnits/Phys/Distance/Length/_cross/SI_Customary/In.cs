namespace MeasUnits.Phys.Distance.Length.Cross.SI_Customary;

[Factored]
public enum In
{
    Undefined = 0,

    [Abbr("mm")]
    millimeter = 10,
    [Abbr("cm")]
    centimeter = 100,

    [Alias("metre")]
    [Abbr("m")]
    meter = 10_000,

    [Abbr("in")]
    inch = 254,
    [Abbr("ft")]
    foot = 254 * 12,

    yard = 254 * 12 * 3,

    [Abbr("km")]
    kilometer = 10_000_000,
    [Abbr("mi")]
    mile = 16_093_440,
    [Abbr("nmi")]
    nautical_mile = 18_520_000,
}
