namespace MeasData.Temperature.PhaseChange;
public partial class PhaseChange
{
    Dir Melting = new() {
        [water] = [(0.01, Celsius), (0.01 + KelvinOffset, Kelvin), (32.018, Fahrenheit)],
        [table_salt] = [(800.7, Celsius), (1_473.3, Fahrenheit)],
        [jet_fuel] = [(-47, Celsius), (-52.6, Fahrenheit)],

        [Gallium] = [(302.914_6, Kelvin), (29.764_6, Celsius), (85.576_3, Fahrenheit)],
        [Quicksilver] = [(234.32, K), (-38.83, C), (-37.894, F)],
        [Silver] = [(1_234.93, K), (961.78, C), (1_763.204, F)],
        [Gold] = [(1_337, K), (1_064, C), (1_947, F)],
        [Iron] = [(1_811.15, K), (1_538, C), (2_800.4, F)],
        [Platinum] = [(Pt_C + KelvinOffset, K), (Pt_C, C), (3_214.94, F)],
        [Tungsten] = [(Pt_W + KelvinOffset, K), (Pt_W, C), (6_191.6, F)],

        [sulfuric_acid] = [(10.31, C), (50.56, F)],
        [nitric_acid] = [(-42, C), (-44, F)],

        [methane] = [(-182.456, C), (-296.421, F)],
        [ammonia] = [(-77.73, C), (-107.91, F)],

        [acetone] = [(-94.9, Celsius), (-138.8, Fahrenheit)],
        [ethanol] = [(-114.14, Celsius), (-173.45, F)],
        [methanol] = [(-97.6, Celsius), (-143.7, F)],

    };

    private const double Pt_C = 1_768.3;
    private const double Pt_W = 3_422.00;
}



