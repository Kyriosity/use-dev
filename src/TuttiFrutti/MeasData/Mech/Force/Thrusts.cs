namespace MeasData.Mech.Force;
public partial class Forces
{
    Dir TurbofanTakeoff = new() {
        ["GE Aviation GE9X"] = [(110_000, pound_force), (489.3, kilonewton)],
        ["Rolls-Royce Trent 900"] = [(374.09, kN), (84_098, lbf)],
    };

    Dir Turbojet_Max = new() {
        ["Rolls-Royce/Snecma Olympus 593"] = [(169, kN), (38_050, lbf)], // reheat
    };

    Dir Turboprop_Max = new() {
        //["Europrop TP400"] = [(, ), (, )],
        ["Pratt & Whitney/Allison 578-DX"] = [(22_000, lbf), (98, kN)],
        ["Lycoming O-360"] = [(753.11, lbf), (3_350, newton)], // Cessna 172
    };
}
