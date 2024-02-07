using MeasData.Setup.Metadata;

namespace MeasData.Digital.Size;
public partial class Size
{
    Dir Ancient = new() {

        ["Punch-card, 12-row/80-col, IBM"] = [(80, Size.bytes), (640, Size.bits), (40, Size.words)],
        ["Drum Series 1100, UNIVAC,"] = [(180_000 * 6, Size.bits), (1_054.6875, Size.KBytes), (1.029_968, Size.MB)],
    };

    Dir HDD = new() {
        ["IBM 350, 1956"] = [(3.75, Size.megabyte), (3_840, Size.KB), (3_932_160, Size.bytes), (31_457_280, Size.bits)],
        ["IBM Travelstar, Nov/2002"] = [(80, Size.GByte)], // 2.75×0.38×3.95"
        ["IBM Deskstar, Oct/2002"] = [(180, Size.GByte), (0.175_781_25, Size.TByte)], // 4×1×5.75"

        ["Ultrastar DC HC680, 2023"] = [(28, Size.terabytes), (28_672, Size.gigabytes)], // 4×1×5.75"
    };

    [Precision(1.01)]
    Dir Floppy = new() {
        ["Floppy 8 inch, 1972"] = [(175, Size.KByte), (179_200, Size.bytes)], // 1st commercial r/w
        ["5 1/4 inch minifloppy, 1976"] = [(113, Size.KByte), (115_712, Size.bytes)],
        ["5 1/4\", Tandon, 1980"] = [(0.36, Size.MB), (368.84, Size.KB), (377_692, Size.bytes)],
        ["5 1/4\", IBM, 1984"] = [(1.2, Size.MByte), (1_228_800, Size.bytes)],
        ["3 1/2 in. IBM, high-density, 1987"] = [(1.44, Size.MB), (1_475, Size.KB), (1_509_949, Size.bytes)],
        ["3 1/2 in. Y-E Data, double-side ext-density, 1989"] = [(2.88, Size.MByte), (2_949, Size.KBytes)],
    };

    Dir OpticalDrive = new() {
        ["CD"] = [(650, Size.MB), (.634_765, Size.GB), (665_600, Size.KByte)],
        ["DVD"] = [(4.7, Size.GB), (4_812.8, Size.MB)],
        ["DVD, dual-layer"] = [(8.5, Size.GB), (8_704, Size.MB), (8_912_896, Size.KB), (9_126_805_504, Size.bytes)],
        ["Blu-Ray, quadruple-layer"] = [(128, Size.GB), (131_072, Size.MB)],
    };

    Dir RAM = new() {
        ["Fairchild SRAM, 1963"] = [(1, Size.bit), (.5, Size.crumb), (.25, Size.nibble)],
        ["IBM SP95, 1965"] = [(16, Size.bits), (4, Size.nibble), (8, Size.crumb), (2, Size.bytes), (1, Size.word), (.5, Size.doubleword)],
        ["Intel MOSFET, 1972"] = [(1, Size.kilobits), (128, Size.bytes), (64, Size.words), (16, Size.quadwords)],

        ["Samsung KM48SL2000, 1992"] = [(16, Size.megabits), (16_384, Size.kilobits)], // 1st commercial SDRAM 
        ["Toshiba TC51W3216XB pseudo SRAM, 2001"] = [(32, Size.megabits), (.031_25, Size.gigabits), (32_768, Size.kilobits)],
        ["Samsung DRAM 100nm, 2001"] = [(4, Size.gigabits), (.5, Size.GB), (512, Size.MB)],

        ["Samsung HBM2, 2017"] = [(64, Size.gigabits), (8_192, Size.MB), (8_388_608, Size.KBytes)],
        ["Samsung K4ZAF325BM, 10nm, 2018"] = [(16, Size.gigabits), (2_048, Size.MB), (2_097_152, Size.KBytes)],
        ["Samsung DDR4, 10nm, 2018"] = [(128, Size.gigabits), (0.015_625, Size.TB), (16_384, Size.MB)],
    };

    Dir SSD = new() {
        ["SanDisk Cruzer USB drive, 2011"] = [(4, Size.GB), (4_096, Size.MB)],
        ["Memory Stick PRO, 2003"] = [(128, Size.MB), (.125, Size.GB)],
        ["Memory Stick PRO-HG Duo, 2006"] = [(8, Size.GB), (8_192, Size.MB), (.007_8125, Size.TB)],
        ["Enterprise Nimbus Data DC100, 2018"] = [(100, Size.TB), (102_400, Size.GB), (104_857_600, Size.MB)],
    };
}
