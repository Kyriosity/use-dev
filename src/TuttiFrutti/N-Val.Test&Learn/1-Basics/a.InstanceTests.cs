using Mk.N_Val.Phys.Temperature.Build;
using System.Numerics;
using TestData.N_Val.Temperatures;

namespace N_Val.Test_Learn.Declaration;

public class InstanceTests
{
    [TestCaseSource(typeof(Mixture), nameof(Mixture.NumericTypes))]
    public void CreateAndCrossCompare<N>(string id, (N kelvin, N celsius, N fahrenheit, N delta) values) where N : INumber<N> {
        var baseK = Temperature.Kelvin(values.kelvin);
        var baseC = Temperature.Celsius(values.celsius);
        var baseF = Temperature.Fahrenheit(values.fahrenheit);

        Assert.That(baseK.Kelvin, Is.EqualTo(baseC.Kelvin).Within(values.delta), $"C->K ({id})");
        Assert.That(baseK.Celsius, Is.EqualTo(baseC.Celsius).Within(values.delta), $"K->C ({id})");

        Assert.That(baseC.Celsius, Is.EqualTo(baseF.Celsius).Within(values.delta), $"F->C ({id})");
        Assert.That(baseC.Fahrenheit, Is.EqualTo(baseF.Fahrenheit).Within(values.delta), $"C->F ({id})");

        Assert.That(baseK.Kelvin, Is.EqualTo(baseF.Kelvin).Within(values.delta), $"F->K ({id})");
        Assert.That(baseK.Fahrenheit, Is.EqualTo(baseF.Fahrenheit).Within(values.delta), $"K->F ({id})");
    }

    [TestCaseSource(typeof(Mixture), nameof(Mixture.NumericTypes))]
    public void CreateAndReAssign<N>(string id, (N K, N C, N F, N delta) values) where N : INumber<N> {
        var temperature = Temperature.Kelvin(values.K);
        var bulb = values.delta + N.CreateChecked(1);

        temperature.Celsius = values.C + bulb;
        Assert.That(temperature.Kelvin, Is.Not.EqualTo(values.K), $"{nameof(Temperature.Celsius)} set");

        temperature = Temperature.Celsius(values.C);
        temperature.Fahrenheit = values.F - bulb;
        Assert.That(temperature.Celsius, Is.Not.EqualTo(values.C), $"{nameof(Temperature.Fahrenheit)} set");

        temperature = Temperature.Fahrenheit(values.F);
        temperature.Kelvin = values.K - bulb;
        Assert.That(temperature.Fahrenheit, Is.Not.EqualTo(values.F), $"{nameof(Temperature.Kelvin)} set");
    }

    [TestCase]
    public void DeclareConstants() {
        Assert.Ignore("Implemented next with fabrics");
    }
}