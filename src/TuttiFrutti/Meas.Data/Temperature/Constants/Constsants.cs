using Meas.Data.Setup.Metadata;

namespace Meas.Data.Temperature;
public partial class Constants : Meas.Data.Temperature.Setup.Synonyms
{
    [Precision(.000_001)]
    Dir Theory = new() {
        [AbsZero] = [(0, Kelvin), (-273.15, Celsius), (-459.67, Fahrenheit)],
        ["Max-Planc atomic gas"] = [(-0.000_000_001, Kelvin), (-459.670_000_001_8, F)], // www.mpg.de/research/negative-absolute-temperature
    };
}
