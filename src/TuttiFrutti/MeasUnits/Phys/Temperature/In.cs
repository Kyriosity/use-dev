namespace MeasUnits.Phys.Temperature;
public enum In
{
    Undefined = 0,

    Kelvin,
    Celsius,
    Fahrenheit,

    Newton, // 
    Rankine,
    Delisle, // Joseph-Nicolas Delisle

    [Alias("Rømer")]
    Romer,
    [Alias("Réaumur")]
    Reaumur
}
