namespace MeasData.Temperature.PhaseChange;
public partial class PhaseChange
{
    Dir Vaporization = new() {
        [water] = [(99.97, Celsius), (99.97 + KelvinOffset, Kelvin), (211.946, Fahrenheit)],
        [table_salt] = [(1_465, Celsius), (2_669, Fahrenheit)],
        [jet_fuel] = [(176, Celsius), (348.8, Fahrenheit)],

        [Gallium] = [(2_676, K), (4_357, F)],
        [Helium] = [(He_C + KelvinOffset, K), (He_C, C), (-452.0704, F)],
        [Hydrogen] = [(H_C + KelvinOffset, K), (H_C, C), (-423.1822, F)],
        [Nitrogen] = [(77.355, Kelvin), (-195.795, Celsius), (-320.431, F)],
        [CO2] = [(-78.464_5, C), (-109.2361, F)], // sublimation

        [sulfuric_acid] = [(337, C), (639, F)],
        [nitric_acid] = [(83, C), (181, F)],

        [methane] = [(-161.5, C), (-258.7, F)],
        [ammonia] = [(-33.34, C), (-28.01, F)],

        [acetone] = [(56.08, Celsius), (132.94, Fahrenheit)],
        [methanol] = [(64.7, Celsius), (148.5, F)],
        [ethanol] = [(78.23, Celsius), (172.81, F)],
    };

    private const double H_C = -252.879;
    private const double He_C = -268.928;
}


