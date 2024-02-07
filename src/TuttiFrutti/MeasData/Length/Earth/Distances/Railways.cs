using MeasData.Length.Setup;
using MeasData.Setup.Metadata;

namespace MeasData.Length.Earth.Distances;
public partial class Distances
{
    [NotForTest("precision too low")] // consider specifying delta of data as +/-.5
    Dir Railways = new() {
        ["Sydney-Perth"] = [(4_352, Synonyms.km), (2_704, Synonyms.miles), (2_350, Synonyms.nmi)],
        ["Kanyakumari, Tamil Nadu-Dibrugarh, Assam"] = [(4_237, Synonyms.km), (2_633, Synonyms.miles), (2_336, Synonyms.nmi)],
        ["Toronto-Vancouver"] = [(4_466, Synonyms.km), (2_775, Synonyms.miles), (2_411.5, Synonyms.nmi)],

        ["Tokyo-Hakata"] = [(1_175, Synonyms.km), (730, Synonyms.miles), (634, Synonyms.nmi)],
        ["Cheongnyangni-Bujeon"] = [(483, Synonyms.km), (300, Synonyms.miles), (261, Synonyms.nmi)],
        ["Taipei-Hualien"] = [(752, Synonyms.km), (467, Synonyms.miles), (406, Synonyms.nmi)],
        ["Malmö-Innsbruck"] = [(1_720, Synonyms.km), (1_069, Synonyms.miles), (929, Synonyms.nmi)],
        ["Stockholm-Berlin"] = [(1_450, Synonyms.km), (901, Synonyms.miles), (783, Synonyms.nmi)],
        ["Vienna-Rostock"] = [(1_240, Synonyms.km), (770.5, Synonyms.miles), (670, Synonyms.nmi)],
        ["Buenos Aires-Tucuman"] = [(1_170, Synonyms.km), (727, Synonyms.miles), (632, Synonyms.nmi)],
        ["Auckland-Wellington"] = [(682, Synonyms.km), (424, Synonyms.miles), (368, Synonyms.nmi)],
    };
}
