using Meas.Data.Setup.Attributes;

namespace Meas.Data.Digital;
public partial class Size
{
    Dir Ancient = new() {

        ["Punch-card, 12-row/80-col, IBM"] = [(80, bytes), (640, bits), (40, words)],
        ["Drum Series 1100, UNIVAC,"] = [(180_000 * 6, bits), (1_054.6875, KBytes), (1.029_968, MB)],
    };

    Dir HDD = new() {
        ["IBM 350, 1956"] = [(3.75, megabyte), (3_840, KB), (3_932_160, bytes), (31_457_280, bits)],
        ["IBM Travelstar, Nov/2002"] = [(80, GByte)], // 2.75×0.38×3.95"
        ["IBM Deskstar, Oct/2002"] = [(180, GByte), (0.175_781_25, TByte)], // 4×1×5.75"

        ["Ultrastar DC HC680, 2023"] = [(28, terabytes), (28_672, gigabytes)], // 4×1×5.75"
    };

    [Precision(1.01)]
    Dir Floppy = new() {
        ["Floppy 8 inch, 1972"] = [(175, KByte), (179_200, bytes)], // 1st commercial r/w
        ["5 1/4 inch minifloppy, 1976"] = [(113, KByte), (115_712, bytes)],
        ["5 1/4\", Tandon, 1980"] = [(0.36, MB), (368.84, KB), (377_692, bytes)],
        ["5 1/4\", IBM, 1984"] = [(1.2, MByte), (1_228_800, bytes)],
        ["3 1/2 in. IBM, high-density, 1987"] = [(1.44, MB), (1_475, bytes)],
        ["3 1/2 in. Y-E Data, double-side ext-density, 1989"] = [(2.88, MByte), (2_949, bytes)],
    };

    Dir OpticalDrive = new() {
        ["CD"] = [(650, MB), (.634_765, GB), (665_600, KByte)],
        ["DVD"] = [(4.7, GB), (4_812.8, MB)],
        ["DVD, dual-layer"] = [(8.5, GB), (8_704, MB), (8_912_896, KB), (9_126_805_504, bytes)],
        ["Blu-Ray, quadruple-layer"] = [(128, GB), (131_072, MB)],
    };

    Dir RAM = new() {
        ["Fairchild SRAM, 1963"] = [(1, bit), (.5, crumb), (.25, nibble)],
        ["IBM SP95, 1965"] = [(16, bits), (4, nibble), (8, crumb), (2, bytes), (1, word), (.5, doubleword)],
        ["Intel MOSFET, 1972"] = [(1, kilobits), (128, bytes), (64, words), (16, quadwords)],

        ["Samsung KM48SL2000, 1992"] = [(16, megabits), (16_384, kilobits)], // 1st commercial SDRAM 
        ["Toshiba TC51W3216XB, 2001"] = [(32, megabits), (32_768, gigabits), (33_554_432, kilobits), (.003_906_25, TB)],
        ["Samsung DRAM 100nm, 2001"] = [(4, gigabits), (.5, GB), (512, MB)],

        ["Samsung HBM2, 2017"] = [(64, gigabits), (8_192, MB), (8_388_608, KBytes)],
        ["Samsung K4ZAF325BM, 10nm, 2018"] = [(16, gigabits), (2_048, MB), (2_097_152, KBytes)],
        ["Samsung DDR4, 10nm, 2018"] = [(128, gigabits), (0.015_625, TB), (16_384, MB)],
    };

    Dir SSD = new() {
        ["SanDisk Cruzer USB drive, 2011"] = [(4, GB), (4_096, MB)],
        ["Memory Stick PRO, 2003"] = [(128, MB), (.125, GB)],
        ["Memory Stick PRO-HG Duo, 2006"] = [(8, GB), (8_192, MB), (.007_8125, TB)],
        ["Enterprise Nimbus Data DC100, 2018"] = [(100, TB), (102_400, GB), (104_857_600, MB)],
    };
}
