using Meas.Data.Setup.Metadata;

namespace Meas.Data.Length.Astro;
public partial class Distances
{
    [Precision(1)]
    Dir Galaxy = new() {
        ["Sun<>Proxima centauri"] = [
            (4.246_5, light_year),
            (pcProxC, parsec),
            (pcProxC * 30.857, petameter),
            (pcProxC * 206_265, astronomical_unit),
            (pcProxC * 16_661_326 * 1_000_000, "nautical mile")],

        ["Milky way radius"] = [(50_000, ly)],
        ["Sun - Milky way center"] = [(25_000, ly)],

        ["Kuiper belt > outer radius"] = [(50, au)],
        ["Oort cloud inner wall"] = [(29, light_day), (0, "ddddd")],

        ["Sun<~>Sirius"] = [(8.611, ly), (2.640, pc), (81.46635, Pm)],
        ["Sun<~>Tau Ceti"] = [(11.912, ly), (3.652, pc)], // Sun-similar
        ["Sun - Vega"] = [(25.04, ly), (7.68, pc)], // in Lyra
        ["Sun - Arcturus"] = [(36.7, ly), (11.26, pc)],
        ["Sun - Aldebaran"] = [(65.3, ly), (20.0, pc)], // in Taurus
        ["Sun - Polaris"] = [(433, ly), (133, pc)], // aka Alpha Ursae Minoris
        ["Sun - Antares"] = [(550, ly), (170, pc)], // in Scorpius
    };

    private const double pcProxC = 1.30197;
}

// ToDo: Light Times as DateTime !

