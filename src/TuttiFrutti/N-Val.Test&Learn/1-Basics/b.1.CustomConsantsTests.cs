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

        Assert.That(Space.Outer.Kelvin, Is.GreaterThan(Gen.AbsZero.Kelvin));

        var ambient = Temperature.Celsius(21.3);
        var kWhForTea = 4.2 * 0.5 * (Water.Boiling.Kelvin - ambient.Kelvin) / 3600; // well, w/out energy for state transition
    }

    [TestCase]
    public void Create() {
        var finalBookTitle = Temperature.Const.Fahrenheit(451);

        var seasonMaiSeptemberWaterSurface = new[] { 20.27, 22.9, 25.31, 24.88, 22.15 };
        var averagedSeaWater = Temperature.Const.Celsius(seasonMaiSeptemberWaterSurface.Average());

        var subtractStep = Temperature.Const.All(kelvin: -100, celsius: -373.15, fahrenheit: -639.67);
        var nonsense = Temperature.Const.All(1, 1, 1);

        var roughBenchmark = Temperature.Const.All(kelvin: 310.0, celsius: 37.0, fahrenheit: 98.0);
        var idealAlloyMelting = Temperature.Const.All(1_570.7_605_418, 1_297.6_105_418, 2_367.69_897_524);
    }

    public void CreateExplicitlyTyped() {
        var middleSeatemperature = Temperature.Celsius<short>(23);

        var alphaCentauriYearlyRecord = Temperature.Kelvin<float>(5015.2f);
    }
}
