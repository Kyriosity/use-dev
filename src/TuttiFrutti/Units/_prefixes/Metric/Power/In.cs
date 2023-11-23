namespace Units.Prefix.Metric.Power;
public enum In // : IPow10
{
    quecto = -30,
    ronto = -27,
    yocto = -24,
    zepto = -21,
    atto = -18,
    femto = -15,
    pico = -12,
    nano = -9,
    micro = -6,
    milli = -3,
    centi = -2,
    deci = -1,

    Base = 0,

    deca = 1,
    hecto = 2,
    kilo = 3,
    mega = 6,
    giga = 9,
    tera = 12,
    peta = 15,
    exa = 18,
    zetta = 21,
    yotta = 24,
    ronna = 27,
    quetta = 30
}

public interface IPow10 { }
