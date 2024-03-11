namespace MeasUnits.Phys.Pressure;
public enum In
{
    Undefined = 0,

    [Alias("Pa")]
    Pascal = 1,

    bar,

    standardAtmosphere,
    technicalAtmosphere,

    torr, // Evangelista Torricelli, barometer principle, 1644. 1 Torr = 0.999999857533699 mmHg

    [Alias("mmHg")]
    millimetersMercury,

    [Alias("inHg")]
    inchesMercury,

    [Alias("PSI")]
    poundPerSquareInch
}


