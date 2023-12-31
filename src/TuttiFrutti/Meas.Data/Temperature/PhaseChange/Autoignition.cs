using Meas.Data.Setup.Attributes;

namespace Meas.Data.Temperature;

public partial class PhaseChange
{
    [NotForTest]
    public static readonly Dir Autoignition = new() {
        [jet_fuel] = [(210, Celsius), (410, Fahrenheit)],

        [Lead] = [(850, Celsius), (1_562, Fahrenheit)],
        [Iron] = [(1_588, K), (2_399, F)],

        ["Paper"] = [(451, Fahrenheit), (232.778, Celsius)],
        [triethylborane] = [(-20, C), (-4, F)],
        [white_phosphorus] = [(34, C), (93, F)],

        [methanol] = [(433.1, Celsius), (811.58, Fahrenheit)],
        [ethanol] = [(368.8, Celsius), (695.84, Fahrenheit)],
    };
}

