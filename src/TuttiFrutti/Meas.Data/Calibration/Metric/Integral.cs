using Meas.Data.Calibration.Setup;

namespace Meas.Data.Calibration.Metric;

public class MathIntegral : Synonyms
{
    Rec Based = [
        ((double)1.00, BASE, "~", 1_000_000_000_000_000_000_000_000_000_000.00, "quecto"),
        ((float)1.00, BASE, "~", (float)1_000_000_000_000_000_000_000_000_000.00, "ronto"),
        ((double)1.00, BASE, "~", 1_000_000_000_000_000_000_000_000.00, "yocto"),
        ((double)1.00, BASE, "~", 1_000_000_000_000_000_000_000.00, "zepto"),

        ((long)-9, BASE, "=", -9_000_000_000_000_000_000, "atto"),
        ((ulong)12, BASE, "=", 12_000_000_000_000_000_000, "atto"),
        (1, BASE, "=", 1_000_000_000_000_000_000, "atto"),

        (1, BASE, "=", 1_000_000_000_000_000, "femto"),
        (1, BASE, "=", 1_000_000_000_000, "pico"),
        (1, BASE, "=", 1_000_000_000, nano),

        ((uint)8, BASE, "=", (uint)8_000_000, micro),
        (1, BASE, "=", 1_000_000, micro),

        (1, BASE, "=", 1_000, milli),
        ((float)-11, BASE, "=", (float)-11_000, milli),

        (1, BASE, "=", 100, centi),
        ((byte)1, BASE, "=", (byte)100, centi),

        (1, BASE, "=", 10, deci),

        (1, BASE, "=", 1, BASE),
        ((byte)2, BASE, "=", (byte)2, BASE),

        (10, BASE, "=", 1, deca),
        ((sbyte)-10, BASE, "=", -1, deca),

        (900, BASE, "=", 9, "hecto"),
        ((sbyte)-100, BASE, "=", -1, "hecto"),
        ((short)-200, BASE, "=", (short)-2, "hecto"),

        (1_000, BASE, "=", 1, kilo),
        ((ushort)7_000, BASE, "=", 7, kilo),

        (1_000_000, BASE, "=", 1, mega),

        (1_000_000_000, BASE, "=", 1, giga),
        (4_000_000_000, BASE, "=", (uint)4, giga),

        (1_000_000_000_000, BASE, "=", 1, "tera"),

        (1_000_000_000_000_000, BASE, "=", 1, "peta"),
        ((ulong)2_000_000_000_000_000, BASE, "=", (ulong)2, "peta"),
        (-3_000_000_000_000_000, BASE, "=", (long)-3, "peta"),

        ((float)1_000_000_000_000_000_000_000.00, BASE, "~", (float)1.00, "zetta"),
        ((double)4_000_000_000_000_000_000_000_000.00, BASE, "~", (double)4.00, "yotta"),
        ((double)3_000_000_000_000_000_000_000_000_000.00, BASE, "~", (double)3.00, "ronna"),
        ((double)2_000_000_000_000_000_000_000_000_000_000.00, BASE, "~", (double)2.00, "quetta")
    ];

    Rec Same = [
        ((double)951_234_567_890.00, "hecto", "===", (double)951_234_567_890.00, "hecto"),
        ((double)-2_882.00, deca, "===", (double)-2_882.00, deca),

        ((float)-1_234_567_890, "peta", "===", (float)-1_234_567_890, "peta"),
        ((float)746_234_567_893, "ronna", "===", (float)746_234_567_893, "ronna"),

        ((sbyte)-123, kilo, "===", (sbyte)-123, kilo),
        ((byte)101, micro, "===", (byte)101, micro),
        (-1, BASE, "===", -1, BASE),
        (1, BASE, "===", 1, BASE),
        ((uint)505, BASE, "===", (uint)505, BASE),

        ((ushort)9_777, "quetta", "===", (ushort)9_777, "quetta"),
        ((short)-8_579, centi, "===", (short)-8_579, centi),

        ((long)-82_412, "yotta", "===", (long)-82_412, "yotta"),
        ((ulong)919_747_338, "zepto", "===", (ulong)919_747_338, "zepto"),

        ((decimal)-12_345.00, nano, "===", (decimal)-12_345.00, nano),
        ((decimal)101.00, "pico", "===", (decimal)101.00, "pico"),
    ];

    Rec Cross = [
        ((sbyte)-11, centi, "=", (sbyte)-110, milli),
        ((byte)25, centi, "=", (byte)250, milli),

        // centric
        (3_104, deca, "=", 310_400, deci),
        ((uint)4_321, "hecto", "=", (uint)43_210_000, centi),
        (-3_104, kilo, "=", -310_400, milli),
        (-3_000_000_000_000, micro, "=", (long)-3, mega),
        ((ulong)1_000_000_000_000_000_000, nano, "=", (ulong)1, giga),

        ((float)12_059_163.00, "tera", "=", (float)12_059_163_000_000.00, mega),

        ((double)12.000, kilo, "=", (double)12_000_000_000_000.000, nano),
    ];

    // ToDo: EXTREMES !
}