namespace Data.Setup.Samples.Metric.WholeNumbers;

public static class Based
{
    public readonly static object[][] MultitypeScale = {
            [(double)1.00, "base", "=", 1_000_000_000_000_000_000_000_000_000_000.00, "quecto"],
            [(double)1.00, "base", "=", 1_000_000_000_000_000_000_000_000_000.00, "ronto"],
            [(double)1.00, "base", "=", 1_000_000_000_000_000_000_000_000.00, "yocto"],
            [(double)1.00, "base", "=", 1_000_000_000_000_000_000_000.00, "zepto"],

            [(long)-9, "base", "=", -9_000_000_000_000_000_000, "atto"],
            [(ulong)12, "base", "=", 12_000_000_000_000_000_000, "atto"],
            [1, "base", "=", 1_000_000_000_000_000_000, "atto"],

            [1, "base", "=", 1_000_000_000_000_000, "femto"],
            [1, "base", "=", 1_000_000_000_000, "pico"],
            [1, "base", "=", 1_000_000_000, "nano"],

            [(uint)8, "base", "=", (uint)8_000_000, "micro"],
            [1, "base", "=", 1_000_000, "micro"],

            [1, "base", "=", 1_000, "milli"],

            [1, "base", "=", 100, "centi"],
            [(byte)1, "base", "=", (byte)100, "centi"],

            [1, "base", "=", 10, "deci"],

            [1, "base", "=", 1, "base"],
            [(byte)2, "base", "=", (byte)2, "base"],

            [10, "base", "=", 1, "deca"],

            [100, "base", "=", 1, "hecta"],
            [(short)-200, "base", "=", (short)-2, "hecta"],

            [1_000, "base", "=", 1, "kilo"],
            [(ushort)7_000, "base", "=", 7, "kilo"],

            [1_000_000, "base", "=", 1, "mega"],

            [1_000_000_000, "base", "=", 1, "giga"],
            [4_000_000_000, "base", "=", 4, "giga"],

            [1_000_000_000_000, "base", "=", 1, "tera"],

            [1_000_000_000_000_000, "base", "=", 1, "peta"],
            [1_000_000_000_000_000_000, "base", "=", (long)1, "peta"],
            [(ulong)2_000_000_000_000_000_000, "base", "=", (ulong)2, "peta"],

            [(double)1_000_000_000_000_000_000_000.00, "base", "=", (double)1.00, "zetta"],
            [(double)4_000_000_000_000_000_000_000_000.00, "base", "=", (double)4.00, "yotta"],
            [(double)3_000_000_000_000_000_000_000_000_000.00, "base", "=", (double)3.00, "ronna"],
            [(double)2_000_000_000_000_000_000_000_000_000_000.00, "base", "=", (double)2.00, "quetta"],
    };
}
