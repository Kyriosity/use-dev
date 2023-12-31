using Meas.Data.Setup.Attributes;

namespace Meas.Data.Temperature;
public partial class PhaseChange
{
    [NotForTest]
    public static readonly Dir FlashPoint = new() {
        [jet_fuel] = [(38, Celsius), (100.4, Fahrenheit)],

        [acetone] = [(-20, Celsius), (-4, Fahrenheit)],
        ["benzene"] = [(-12, Celsius), (10.4, Fahrenheit)],
        [ethanol] = [(14, Celsius), (57.2, Fahrenheit)],
    };
}