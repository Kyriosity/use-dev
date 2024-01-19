namespace Meas.Data.Digital;
public partial class Calibration : Synonyms
{
    Rec Zero = [
        (0, BASE, "=", 0, yobi),
        ((double).00, zebi, "=", .000, tebi),
        (double.NegativeZero, pebi, "=", .000, mebi),
        ((byte)0, exbi, "=", (byte)0, BASE),
    ];

    Rec Cross = [
        (-3_072, BASE, "=", -3, kibi),
        ((int)2_097_152, mebi, "=", 2, BASE),

        (-4_194_304, tebi, "=", -4, exbi),
        (5, yobi, "=", 5_242_880, exbi),

        ((short)1, kibi, "=", (short)1_024, BASE),
        ((short)-11, kibi, "=", (short)-11_264, BASE),

        ((double).0123_45, mebi, "===", (double)12_944.670_72, tebi),
        ((double)-764.928, yobi, "~", (double)-.747, zebi),

        ((long)1_984, gibi, "=", (long)2_130_303_778_816, BASE),
        (4_934_656, BASE, "=", 81, mebi),

        ((ushort)63, pebi, "=", (ushort)64_512, exbi),
        ((uint)3_221_225_472, BASE, "==", (uint)3, gibi),
        ((ulong)1, BASE, "=", (ulong)1_099_511_627_776, tebi),
    ];
}

