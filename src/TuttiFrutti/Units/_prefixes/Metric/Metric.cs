namespace Units.Prefix.Metric;
public enum In : long
{
    //zepto = -1_000_000_000_000_000_000_000, // too large for enum
    atto = -1_000_000_000_000_000_000,
    femto = -1_000_000_000_000_000,
    pico = -1_000_000_000_000,
    nano = -1_000_000_000,
    micro = -1_000_000,
    milli = -1_000,
    centi = -100,
    deci = -10,

    Base = 1,

    deca = 10,
    hecto = 100,
    kilo = 1_000,
    mega = 1_000_000,
    giga = 1_000_000_000,
    tera = 1_000_000_000_000,
    peta = 1_000_000_000_000_000,
    exa = 1_000_000_000_000_000_000,
    //zetta = 1_000_000_000_000_000_000_000,
}

