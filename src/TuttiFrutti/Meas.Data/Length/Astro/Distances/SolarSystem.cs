using Meas.Data.Setup.Attributes;

namespace Meas.Data.Length.Astro;
public partial class Distances
{
    [NotForTest("Draft")]
    Dir SolarSystem = new() {
        ["Moon orbit"] = [(0, "asda"), (0, "ddddd")]

        ,
        ["Earth orbit"] = [(1.0, "astro unit"), (8.3, "light minute"), (0, "ddddd")],
        [" orbit"] = [(0, "light minute"), (0, "sdfsd")],
        [" orbit"] = [(0, "light minute"), (0, "sdfsd")],
        ["Jupiter orbit"] = [(43.2, "light minute"), (0, "sdfsd")],

    };
}

