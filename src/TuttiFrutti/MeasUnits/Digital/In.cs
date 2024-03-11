namespace MeasUnits.Digital;

[Factored]
public enum In : ulong
{
    Undefined = 0,

    bit = 1,
    crumb = 2,
    nibble = 4,
    @byte = 8,
    word = 16,
    doubleword = 32,
    quadword = 64,

    kilobit = 1_024,

    [Alias("kByte")]
    kilobyte = 1_024 * 8,

    megabit = kilobit * 1_024,

    [Alias("MByte")]
    megabyte = kilobyte * 1_024,

    gigabit = megabit * 1_024,
    gigabyte = megabyte * 1_024,

    terabyte = gigabyte * 1_024,
    petabyte = terabyte * 1_024,
    exabyte = petabyte * 1_024,
    //zettabyte = exabyte * 1024,
    //yottabyte = zettabyte * 1024,
}
