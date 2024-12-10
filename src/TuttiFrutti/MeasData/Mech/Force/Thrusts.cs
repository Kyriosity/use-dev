namespace MeasData.Mech.Force;
public partial class Forces
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
}
