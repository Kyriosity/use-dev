using Mk.N_Val.Phys.Temperature.Build;
using System.Numerics;
using TD.N_Val;

namespace N_Val.Test_Learn.Declaration;

public class ConceptProofTests
{
    [Test, TestCaseSource(typeof(TestArgs.Temperatures), nameof(TestArgs.Temperatures.MutitypeValues_KelvinCelciusFahrenheit))]
    public void DeclareAndCrossCompare<N>(string id, (N kelvin, N celsius, N fahrenheit, N delta) of) where N : INumber<N> {
        var kInit = Temperature.Kelvin(of.kelvin);
        var cInit = Temperature.Celsius(of.celsius);
        var fInit = Temperature.Fahrenheit(of.fahrenheit);

        Assert.That(kInit.Kelvin, Is.EqualTo(cInit.Kelvin).Within(of.delta), "C->K");
        Assert.That(kInit.Celsius, Is.EqualTo(cInit.Celsius).Within(of.delta), "K->C");

        Assert.That(cInit.Celsius, Is.EqualTo(fInit.Celsius).Within(of.delta), "F->C");
        Assert.That(cInit.Fahrenheit, Is.EqualTo(fInit.Fahrenheit).Within(of.delta), "C->F");

        Assert.That(kInit.Kelvin, Is.EqualTo(fInit.Kelvin).Within(of.delta), "F->K");
        Assert.That(kInit.Fahrenheit, Is.EqualTo(fInit.Fahrenheit).Within(of.delta), "K->F");
    }
}