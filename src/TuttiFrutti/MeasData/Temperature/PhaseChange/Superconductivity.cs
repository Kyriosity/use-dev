namespace MeasData.Temperature.PhaseChange;
public partial class PhaseChange
{
    Dir Superconductivity = new() {
        [Gallium] = [(1.09, Kelvin), (-272.06, Celsius), (-457.708, Fahrenheit)],
        [Mercury] = [(4.15, Kelvin), (-269, Celsius), (-452.2, F)],
        ["magnesium diboride"] = [(39, K), (-234.15, C), (-389.47, F)],

        // high temperature (above nitrogen boiling 77.355K)

        ["bismuth strontium calcium copper oxide"] = [(110, Kelvin), (-163.15, Celsius), (-261.67, Fahrenheit)],

    };
}
