namespace Meas.Data.Length.Earth;
public partial class Distances
{
    Dir Geo = new() {
        ["Equator"] = [(40_075, km), (24_901.45, miles), (21_638.77, nautical_miles)],


        ["Equatorial diameter"] = [(12_756, km), (7_926.21, mi), (6_887.69, nmi)],
        ["Polar diameter"] = [(12_713.6, km), (7_899.865, mi), (6_864.795, nmi)],

        ["Chile N-S"] = [(4_269.59, km), (2_653, miles), (2_305.6, nmi)],
    };
}
