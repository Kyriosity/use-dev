using MeasData.Setup.Metadata;

namespace MeasData.Mech.Force;

[Precision(0.000_000_1)]

public partial class Dirs
{
    Dir TurbofanTakeoff = new() {
        ["GE Aviation GE9X"] = [(110_000, pound_force), (489.3, kilonewton), (110, kilopound)],
        ["Rolls-Royce Trent 900"] = [(374.09, kN), (84_098, lbf)],
    };

    Dir Turbojet_Max = new() {
        ["Rolls-Royce/Snecma Olympus 593"] = [(169, kN), (38_050, lbf), (169_000, newton)], // reheat
    };

    Dir Turboprop_Max = new() {
        //["Europrop TP400"] = [(, ), (, )],
        ["Pratt & Whitney/Allison 578-DX"] = [(22_000, lbf), (98, kN)],
        ["Lycoming O-360"] = [(753.11, pound_force), (12_049.76, ounce_force), (3_350, newton), (3.35, kilonewton)], // Cessna 172
    };

    [Precision(.1)]
    Dir Rockets_SeaLevel = new() {
        ["RS-25"] = [(418_000, lbf), (1_859_000, newton), (1_859, kN)], // Space Shuttle Main Engine

        ["ISRO, Launch Vehicle Mark-3 (Stage 1)"] = [(5_150, kN), (1_157_766, lbf)],

        ["JAXA, Epsilon"] = [(2_271, kN), (510_541, lbf)],

        ["Rocket Lab, Archimedes "] = [(200_080, lbf), (890, kN)], // methane

        ["Ariane Vulcain 2.1"] = [(939.5, kN), (211_208, lbf), (939_500, newton)],

        ["Avio, Vega E, P120 C (Stage 1)"] = [(4_500, kN), (1_011_640, lbf)],
        ["Avio, Vega E, Zefiro 40 (Stage 2)"] = [(1_304, kN), (293_151, lbf)],
        ["Avio, Vega E, M10 (Stage 3)"] = [(98, kN), (22_031, lbf)] //  first European Methane engine and stage,
    };
}
