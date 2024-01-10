namespace Meas.Data.Mass;
public partial class Constructs
{
    Dir Spacecrafts = new() {
        ["Saturn I, dry mass"] = [(1_124_000, lb), (509_838, kg)],

        ["Voyager I, dry mass"] = [(721.9, kg), (1591.517_1, lb)],
        ["Voyager I, launch mass"] = [(815, kg), (1_797, lb)],

        ["OSIRIS-REx, dry mass"] = [(880, kg), (1_940, lb)], // sample mission to `101955 Bennu`
        ["OSIRIS-REx, launch mass"] = [(2_110, kg), (4_650, lb)],
    };
}

