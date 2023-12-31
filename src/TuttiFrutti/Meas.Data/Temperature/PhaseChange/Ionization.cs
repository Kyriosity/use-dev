using Meas.Data.Setup.Attributes;
namespace Meas.Data.Temperature;

public partial class PhaseChange
{
    [NotForTest]
    public static readonly Dir Ionization = new() {
        //[""] = [(0.01, Celsius), , (, Fahrenheit)],
    };

}