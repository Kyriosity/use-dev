using Meas.Data.Setup.Metadata;

namespace Meas.Data.Length.Earth;
public partial class Distances
{
    [NotForTest("precision too low")] // consider specifying delta of data as +/-.5
    Dir Railways = new() {
        ["Sydney-Perth"] = [(4_352, km), (2_704, miles), (2_350, nmi)],
        ["Kanyakumari, Tamil Nadu-Dibrugarh, Assam"] = [(4_237, km), (2_633, miles), (2_336, nmi)],
        ["Toronto-Vancouver"] = [(4_466, km), (2_775, miles), (2_411.5, nmi)],

        ["Tokyo-Hakata"] = [(1_175, km), (730, miles), (634, nmi)],
        ["Cheongnyangni-Bujeon"] = [(483, km), (300, miles), (261, nmi)],
        ["Taipei-Hualien"] = [(752, km), (467, miles), (406, nmi)],
        ["Malmö-Innsbruck"] = [(1_720, km), (1_069, miles), (929, nmi)],
        ["Stockholm-Berlin"] = [(1_450, km), (901, miles), (783, nmi)],
        ["Vienna-Rostock"] = [(1_240, km), (770.5, miles), (670, nmi)],
        ["Buenos Aires-Tucuman"] = [(1_170, km), (727, miles), (632, nmi)],
        ["Auckland-Wellington"] = [(682, km), (424, miles), (368, nmi)],
    };
}
