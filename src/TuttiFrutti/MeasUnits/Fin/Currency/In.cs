namespace MeasUnits.Fin.Currency;
public enum In
{
    Undefined = 0, // default

    [Alias("US dollar", "buck")]
    USD,
    [Alias("Canadian dollar")]
    CAD,
    [Alias("New Zealand dollar")]
    NZD,
    EUR,
    [Alias("sterling", "Great Britain pound")]
    GBP,
    [Alias("Australlian dollar")]
    AUD,
    [Alias("Japan Yen")]
    JPY,
    [Alias("Swiss Franc")]
    CHF,
    [Alias("Albanian Lek")]
    ALL,
    [Alias("Norwegian krone")]
    NOK,
    [Alias("South Korean won")]
    KRW,
    [Alias("Kenyan shilling")]
    KES,

    [Alias("Polski Zloty")]
    PLN,
    [Alias("Mongolian Tugrik")]
    MNT,
    [Alias("Kap-Verde Escudo")]
    CVE
}
