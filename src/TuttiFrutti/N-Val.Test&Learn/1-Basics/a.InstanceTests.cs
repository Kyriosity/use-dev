using Mk.N_Val.Phys.Temperature.Build;
using TestData.N_Val.Temperatures;

namespace N_Val.Test_Learn.Declaration;

public class InstanceTests
{
    [TestCaseSource(typeof(Mix), nameof(Mix.NumericTypes))]
    [TestCaseSource(typeof(Mix), nameof(Mix.HugeValues))]
    [TestCaseSource(typeof(Mix), nameof(Mix.ControlPoints))]
    public void CreateAndCrossCompare<N>(string id, (N kelvin, N celsius, N fahrenheit, N delta) vals) where N : INumber<N> {
        var baseK = Temperature.Kelvin(vals.kelvin);
        var baseC = Temperature.Celsius(vals.celsius);
        var baseF = Temperature.Fahrenheit(vals.fahrenheit);

        Assert.That(baseC.Kelvin, Is.EqualTo(baseK.Kelvin).Within(vals.delta), $"C->K ({id})");
        Assert.That(baseK.Celsius, Is.EqualTo(baseC.Celsius).Within(vals.delta), $"K->C ({id})");

        Assert.That(baseF.Celsius, Is.EqualTo(baseC.Celsius).Within(vals.delta), $"F->C ({id})");
        Assert.That(baseC.Fahrenheit, Is.EqualTo(baseF.Fahrenheit).Within(vals.delta), $"C->F ({id})");

        Assert.That(baseF.Kelvin, Is.EqualTo(baseK.Kelvin).Within(vals.delta), $"F->K ({id})");
        Assert.That(baseK.Fahrenheit, Is.EqualTo(baseF.Fahrenheit).Within(vals.delta), $"K->F ({id})");
    }

    [TestCaseSource(typeof(Mix), nameof(Mix.NumericTypes))]
    public void CreateAndReAssign<N>(string id, (N K, N C, N F, N delta) vals) where N : INumber<N> {
        var temperature = Temperature.Kelvin(vals.K);
        var bulb = vals.delta + N.CreateChecked(1);

        temperature.Celsius = vals.C + bulb;
        Assert.That(temperature.Kelvin, Is.Not.EqualTo(vals.K), $"Сelcius={vals.C + bulb}");

        temperature = Temperature.Celsius(vals.C);
        temperature.Fahrenheit = vals.F - bulb;
        Assert.That(temperature.Celsius, Is.Not.EqualTo(vals.C), $"Fahrenheit={vals.F - bulb}");

        temperature = Temperature.Fahrenheit(vals.F);
        temperature.Kelvin = vals.K - bulb;
        Assert.That(temperature.Fahrenheit, Is.Not.EqualTo(vals.F), $"Kelvin={vals.K - bulb}");
    }
}