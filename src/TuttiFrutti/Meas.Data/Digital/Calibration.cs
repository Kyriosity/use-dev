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
        (-3_072, kibi, "=", -3, BASE),
        ((int)2_097_152, mebi, "=", 2, BASE),

        (-4_194_304, tebi, "=", -4, exbi),
        (5, yobi, "=", 5_242_880, exbi),

        ((short)1, BASE, "=", (short)1_024, kibi),
        ((short)-11, kibi, "=", (short)-11_264, BASE),

        ((double).0123_45, mebi, "===", (double)12_944.670_72, tebi), // DEBUG !
        ((double)764.928, yobi, "~", (double)-.747, zebi),

        ((long)1_984, BASE, "=", (long)2_130_303_778_816, gibi),
        (4_934_656, mebi, "=", 81, BASE),

        ((ushort)63, pebi, "=", (ushort)64_512, exbi),
        ((uint)3_221_225_472, gibi, "=", 3, BASE),
        ((ulong)1, BASE, "=", (ulong)1_099_511_627_776, tebi),
    ];
}

