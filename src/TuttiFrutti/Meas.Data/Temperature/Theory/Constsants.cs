namespace Meas.Data.Temperature;
public partial class Theory : Meas.Data.Temperature.Setup.Synonyms
{
    public const string AbsZero = "Absolute zero";
    public const string AbsoluteZero = "Absolute zero";

    public static readonly Dir Constants = new() {
        [AbsZero] = [(0, Kelvin), (-273.15, Celsius), (-459.67, Fahrenheit)],
        ["0 Celcius"] = [(0, Celsius), (273.15, Kelvin), (32, F)],
        ["0 Fahrenheit"] = [(0, Fahrenheit), (-17.777_8, Celsius), (255.372_2, Kelvin)],
        ["Max-Planc atomic gas"] = [(-0.000_000_001, Kelvin), (-459.670_000_001_8, F)], // www.mpg.de/research/negative-absolute-temperature

        ["Quark-gluon plasma, CERN 2012"] = [(5_500_000_000_000, Kelvin), (989_9999_999_54, Fahrenheit)],
    };
}
