namespace Meas.Data.Length.Earth;

public partial class Elevations
{
    Dir TechTowers = new() {
        ["Warsaw radio mast"] = [(646.38, m), (2_120.669, ft)], // collapsed in 1991

        ["Petronius Oil Platform"] = [(640, m), (2100, ft)],  // partially submerged

        ["Tokio Skytree"] = [(634, m), (2080, ft)],

        ["KRDK-TV mast"] = [(627.8, m), (2_059.711, ft)], // N. Dakota, re-built
        ["KXTV/KOVR tower"] = [(624.5, m), (2048.8845, ft)], // California
        ["WRAL HDTV Mast"] = [(609.6, m), (2_000, ft)], // N. Carolina

        ["Toronto CN Tower"] = [(553.3, m), (1_815.3, ft)], // tallest free-standing land struct in W. hemisphere
        ["Berliner Fernsehturm"] = [(368, m), (1_207, ft)],

    };
}