using Mk.N_Val.Phys.Temperature.Build;
using Mk.N_Val.Phys.Temperature.Const;

namespace N_Val.Test_Learn.Basics;
public class CustomConsantsTests
{
    [Test]
    public void UsePredefined() {
        var iceMelting = Temperature.Celsius(0.00d);
        Assert.That(Water.TriplePoint.Fahrenheit,
            Is.EqualTo(iceMelting.Fahrenheit).Within(0.02), "ice-water Fahrnheit");
        Assert.That(Water.TriplePoint.Kelvin,
            Is.EqualTo(iceMelting.Kelvin).Within(0.02), "ice-water Kelvin");

        Assert.That(Space.Outer.Kelvin, Is.GreaterThan(Univ.AbsZero.Kelvin));

        var ambient = Temperature.Celsius(21.3);
        var kWhForTea = 4.2 * 0.5 * (Water.Boiling.Kelvin - ambient.Kelvin) / 3600; // well, energy for state trans
    }

    [TestCase]
    public void Create() {
        var nonsense = Temperature.Const(kelvin: 1, celsius: 1, fahrenheit: 1);

        var subtractStep = Temperature.Const(-100, -373.15, -639.67);

        var measuredSeaWater = Temperature.Const(kelvin: 27.35, celsius: 23.2, fahrenheit: 1947);

        //var finalBookTitle = Temperature.Const.Fahrenheit(451);
    }
}
