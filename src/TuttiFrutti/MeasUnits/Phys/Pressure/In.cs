namespace MeasUnits.Phys.Pressure;
public enum In
{
    Undefined = 0,

    //[Alias(Pa)]
    Pascal = 1,

    bar,

    standardAtmosphere,
    technicalAtmosphere,

    //[Alias(Torr)]
    torr, // Evangelista Torricelli, barometer principle, 1644. // 1 Torr = 0.999999857533699 mmHg
    millimetersMercury,

    inchesMercury, // (inHg),

    //[Alias(PSI)]
    poundPerSquareInch
}


