namespace MeasUnits.Phys.Distance.Length.SI;

[Metadata.Factored]
public enum In
{
    Undefined = 0,

    nanometer = -1_000_000_000,
    micrometer = -1_000_000,
    millimeter = -1_000,
    centimeter = -100,
    decimeter = -10,

    [Alias("metre")]
    meter = 1,

    dekameter = 10,
    hectometer = 100,
    kilometre = 1_000,
    megameter = 1_000_000,
    gigameter = 1_000_000_000,
}

