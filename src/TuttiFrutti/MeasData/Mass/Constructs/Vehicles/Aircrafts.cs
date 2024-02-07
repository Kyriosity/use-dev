namespace MeasData.Mass.Constructs;
public partial class Constructs
{
    Dir Aircrafts = new() {
        ["Airbus A380, max. takeoff"] = [(575_000, kg), (1_267_658, lb)],
        ["Boeing 747, max. takeoff"] = [(833_000, lb), (377_842.444, kg)],

        ["Saab 2000, max. takeoff"] = [(22_800, kg), (50_265, lb)],
        ["ATR 72, max. takeoff"] = [(23_000, kg), (50_265, lb)],

        ["Cirrus Vision SF50, gross weight"] = [(6_000, lb), (2_721.554, kg)],
        ["Cessna 172, gross weight"] = [(2_450, lb), (1_111.3, kg), (1.111_3, tonne)],
    };
}


