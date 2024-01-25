using Meas.Data.Setup.Metadata;

namespace Meas.Data.Length.Astro;
public partial class Distances
{
    [NotForTest("Not enough data")]
    Dir Universe = new() {
        ["Observable radius"] = [(14.26, "gigaparsecs "), (46.5, "light_year")], //  (46.5 billion light-years or 4.40×10pow26 m)

        //Abell 2744, of Pandora's Cluster (3.5 bln ly // opened by James Webb telescope
    };
}
