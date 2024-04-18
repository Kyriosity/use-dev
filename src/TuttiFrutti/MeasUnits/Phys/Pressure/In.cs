namespace MeasUnits.Phys.Pressure;
public enum In
{
    Undefined = 0,

    [Abbr("Pa")]
    Pascal = 1,

    bar,

    standardAtmosphere,
    technicalAtmosphere,

    torr, // Evangelista Torricelli, barometer principle, 1644. 1 Torr = 0.999999857533699 mmHg

    [Abbr("mmHg")]
    millimetersMercury,

    [Abbr("inHg")]
    inchesMercury,

    [Abbr("PSI")]
    poundPerSquareInch
}


