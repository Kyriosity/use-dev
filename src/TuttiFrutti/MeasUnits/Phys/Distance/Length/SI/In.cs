namespace MeasUnits.Phys.Distance.Length.SI;

[Factored]
public enum In
{
    Undefined = 0,

    [Abbr("nm")]
    nanometer = -1_000_000_000,
    [Abbr("mcm", "μm")]
    micrometer = -1_000_000,
    [Abbr("mm")]
    millimeter = -1_000,
    [Abbr("cm")]
    centimeter = -100,
    [Abbr("dm")]
    decimeter = -10,

    [Alias("metre")]
    [Abbr("m")]
    meter = 1,

    dekameter = 10,
    hectometer = 100,
    [Abbr("km")]
    kilometre = 1_000,
    megameter = 1_000_000,
    gigameter = 1_000_000_000,
}

