using MeasData.Setup.Metadata;
using MeasData.Temperature.Setup;

namespace MeasData.Temperature.Constants;
public partial class Constants : Synonyms
{
    [Precision(.000_001)]
    Dir Theory = new() {
        [Constants.AbsZero] = [(0, Kelvin), (-273.15, Celsius), (-459.67, Fahrenheit)],
        ["Max-Planc atomic gas"] = [(-0.000_000_001, Kelvin), (-459.670_000_001_8, F)], // www.mpg.de/research/negative-absolute-temperature
    };
}
