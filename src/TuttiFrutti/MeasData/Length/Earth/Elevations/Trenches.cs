namespace MeasData.Length.Earth.Elevations;
public partial class Dirs
{
    Dir Trenches = new() {
        // Pacific
        ["Mariana Challenger Deep"] = [
            (-10_920, meters),
            (-35_827, feet),
            (-10.920, kilometers),
            (-6.785_373, miles),
            (-11_942.257, yards),
            (-5.896_328, nmi)],
        ["Tonga Horizon Deep"] = [(-10_820, m), (-35_498.688, ft), (-6.723_236, mi), (-5.842_33, nmi)],
        ["Philippine Emden Deep"] = [(-10_540, m), (-34_580.05, ft), (-6.549, mi), (-5.691, nmi)],
        ["Atacama Richards  Deep"] = [(-8_065, m), (-26_459.97, ft), (-4.354_75, nmi)], // Peru-Chile

        // Atlantic
        ["Puerto Rico Brownson Deep"] = [(-8_380, m), (-27_493, ft), (-5.207, mi), (-4.524_838, nmi)],
        ["South Sandwich Metero Deep"] = [(-8_265, m), (-27_116.14, ft), (-4.463, nmi)],
        ["Puerto Rico Rio Bermuda Deep"] = [(-5_625, m), (-18_454.72, ft), (-3.037, nmi)],

        // Indian
        ["Sunda Java Deep"] = [(-7_450, m), (-24_442.26, ft), (-4.629_215, mi), (-4.022_678, nmi)],
        ["Mauritius Point"] = [(-6_875, m), (-22_555.77, ft), (-4.272, mi), (-3.712_203, nmi)],
        ["Ceylon Sri Lanka Deep Deep"] = [(-6_400, m), (-20_997.38, ft), (-3.976_776, mi), (-3.455_724, nmi)],

        // Southern / Antarctic
        ["Factorian Deep"] = [(-7_434, m), (-24_389.76, ft), (-8_129.92, yd), (-4.014, nmi)], // 60° 28' 46"S, 025° 32' 32"W 

        // Arctic 
        ["Litke Deep"] = [(-5_449, m), (-17_877.3, ft), (-3.385_852, mi), (-2.942_225, nmi)],
    };
}


