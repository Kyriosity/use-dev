using Mk.N_Val.Phys.Temperature.Build;
using System.Numerics;
using TD.N_Val;

namespace N_Val.Test_Learn.Declaration;

public class InstanceTests
{
    [Test, TestCaseSource(typeof(TestArgs.Temperatures), nameof(TestArgs.Temperatures.MutitypeNumerics_KelvinCelciusFahrenheit))]
    public void CreateAndCrossCompare<N>(string id, (N kelvin, N celsius, N fahrenheit, N delta) values) where N : INumber<N> {
        var fromK = Temperature.Kelvin(values.kelvin);
        var fromC = Temperature.Celsius(values.celsius);
        var fromF = Temperature.Fahrenheit(values.fahrenheit);

        Assert.That(fromK.Kelvin, Is.EqualTo(fromC.Kelvin).Within(values.delta), $"C->K ({id})");
        Assert.That(fromK.Celsius, Is.EqualTo(fromC.Celsius).Within(values.delta), $"K->C ({id})");

        Assert.That(fromC.Celsius, Is.EqualTo(fromF.Celsius).Within(values.delta), $"F->C ({id})");
        Assert.That(fromC.Fahrenheit, Is.EqualTo(fromF.Fahrenheit).Within(values.delta), $"C->F ({id})");

        Assert.That(fromK.Kelvin, Is.EqualTo(fromF.Kelvin).Within(values.delta), $"F->K ({id})");
        Assert.That(fromK.Fahrenheit, Is.EqualTo(fromF.Fahrenheit).Within(values.delta), $"K->F ({id})");
    }

    [Test, TestCaseSource(typeof(TestArgs.Temperatures), nameof(TestArgs.Temperatures.MutitypeNumerics_KelvinCelciusFahrenheit))]
    public void Assign<N>(string id, (N K, N C, N F, N delta) values) where N : INumber<N> {
        var bulb = values.delta + N.CreateChecked(1);

        var mutant = Temperature.Kelvin(values.K);
        mutant.Celsius = values.C + bulb;
        Assert.That(mutant.Kelvin, Is.Not.EqualTo(values.K), $"{nameof(Temperature.Celsius)} set");

        mutant = Temperature.Celsius(values.C);
        mutant.Fahrenheit = values.F - bulb;
        Assert.That(mutant.Celsius, Is.Not.EqualTo(values.C), $"{nameof(Temperature.Fahrenheit)} set");

        mutant = Temperature.Fahrenheit(values.F);
        mutant.Kelvin = values.K - bulb;
        Assert.That(mutant.Fahrenheit, Is.Not.EqualTo(values.F), $"{nameof(Temperature.Kelvin)} set");

    }

    [Test]
    public void DeclareConstants() {
        Assert.Ignore("Implemented next with fabrics");
    }
}