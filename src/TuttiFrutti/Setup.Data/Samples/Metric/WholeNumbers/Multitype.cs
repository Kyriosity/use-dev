namespace Data.Setup.Samples.Metric.WholeNumbers;

public static class Multitype
{
    public readonly static object[][] Based = {
            [(double)1.00, "base", "~", 1_000_000_000_000_000_000_000_000_000_000.00, "quecto"],
            [(float)1.00, "base", "~", (float)1_000_000_000_000_000_000_000_000_000.00, "ronto"],
            [(double)1.00, "base", "~", 1_000_000_000_000_000_000_000_000.00, "yocto"],
            [(double)1.00, "base", "~", 1_000_000_000_000_000_000_000.00, "zepto"],

            [(long)-9, "base", "=", -9_000_000_000_000_000_000, "atto"],
            [(ulong)12, "base", "=", 12_000_000_000_000_000_000, "atto"],
            [1, "base", "=", 1_000_000_000_000_000_000, "atto"],

            [1, "base", "=", 1_000_000_000_000_000, "femto"],
            [1, "base", "=", 1_000_000_000_000, "pico"],
            [1, "base", "=", 1_000_000_000, "nano"],

            [(uint)8, "base", "=", (uint)8_000_000, "micro"],
            [1, "base", "=", 1_000_000, "micro"],

            [1, "base", "=", 1_000, "milli"],
            [(float)-11, "base", "=", (float)-11_000, "milli"],

            [1, "base", "=", 100, "centi"],
            [(byte)1, "base", "=", (byte)100, "centi"],

            [1, "base", "=", 10, "deci"],

            [1, "base", "=", 1, "base"],
            [(byte)2, "base", "=", (byte)2, "base"],

            [10, "base", "=", 1, "deca"],
            [(sbyte)-10, "base", "=", -1, "deca"],

            [900, "base", "=", 9, "hecto"],
            [(sbyte)-100, "base", "=", -1, "hecto"],
            [(short)-200, "base", "=", (short)-2, "hecto"],

            [1_000, "base", "=", 1, "kilo"],
            [(ushort)7_000, "base", "=", 7, "kilo"],

            [1_000_000, "base", "=", 1, "mega"],

            [1_000_000_000, "base", "=", 1, "giga"],
            [(uint)4_000_000_000, "base", "=", (uint)4, "giga"],

            [1_000_000_000_000, "base", "=", 1, "tera"],

            [1_000_000_000_000_000, "base", "=", 1, "peta"],
            [(ulong)2_000_000_000_000_000, "base", "=", (ulong)2, "peta"],
            [(long)-3_000_000_000_000_000, "base", "=", (long)-3, "peta"],

            [(float)1_000_000_000_000_000_000_000.00, "base", "~", (float)1.00, "zetta"],
            [(double)4_000_000_000_000_000_000_000_000.00, "base", "~", (double)4.00, "yotta"],
            [(double)3_000_000_000_000_000_000_000_000_000.00, "base", "~", (double)3.00, "ronna"],
            [(double)2_000_000_000_000_000_000_000_000_000_000.00, "base", "~", (double)2.00, "quetta"],
    };

    public readonly static object[][] Same = {
        [(double)951_234_567_890.00, "hecto", "===", (double)951_234_567_890.00, "hecto"],
        [(double)-2_882.00, "deca", "===", (double)-2_882.00, "deca"],

        [(float)-1_234_567_890, "peta", "===", (float)-1_234_567_890, "peta"],
        [(float)746_234_567_893, "ronna", "===", (float)746_234_567_893, "ronna"],

        [(sbyte)-123, "kilo", "===", (sbyte)-123, "kilo"],
        [(byte)101, "micro", "===", (byte)101, "micro"],
        [-1, "base", "===", -1, "base"],
        [1, "base", "===", 1, "base"],
        [(uint)505, "base", "===", (uint)505, "base"],

        [(ushort)9_777, "quetta", "===", (ushort)9_777, "quetta"],
        [(short)-8_579, "centi", "===", (short)-8_579, "centi"],

        [(long)-82_412, "yotta", "===", (long)-82_412, "yotta"],
        [(ulong)919_747_338, "zepto", "===", (ulong)919_747_338, "zepto"],

        [(decimal)-12_345.00, "nano", "===", (decimal)-12_345.00, "nano"],
        [(decimal)101.00, "pico", "===", (decimal)101.00, "pico"],
    };

    public readonly static object[][] Cross = {
          [(sbyte)-11, "centi", "=", (sbyte)-110, "milli"],
          [(byte)25, "centi", "=", (byte)250, "milli"],

          // centric
          [3_104, "deca", "=", 310_400, "deci"],
          [(uint)4_321, "hecto", "=", (uint)43_210_000, "centi"],
          [-3_104, "killo", "=", -310_400, "milli"],
          [(long)-3_000_000_000_000, "micro", "=", (long)-3, "mega"],
          [(ulong)1_000_000_000_000_000_000, "nano", "=", (ulong)1, "giga"],


          [(float)12_059_163.00, "tera", "=", (float)12_059_163_000_000.00, "mega"],

          [(double)12.000, "kilo", "=", (double)12_000_000_000_000.000, "nano"],
    };


    // EXTREMES !
}
