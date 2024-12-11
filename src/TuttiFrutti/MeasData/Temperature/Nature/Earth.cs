namespace MeasData.Temperature.Nature;
public partial class Dirs
{
    Dir Earth = new() {
        ["Min, recorded"] = [(183.95, K), (-89.2, C), (-128.56, F)],
        ["Max, recorded"] = [(329.85, K), (56.7, C), (134.06, F)],  // wmo.asu.edu/content/world-highest-temperature
        ["Ocean, average 31Jul2023"] = [(294.114_8, K), (20.9648, C), (69.73664, F)], // max recorded

        ["Magma, Etna"] = [(1_353, K), (1_079.85, C), (1_975.73, F)],
        ["Earth core"] = [(5_473, K), (9391.73, F)]
    };
}