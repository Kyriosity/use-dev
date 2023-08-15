using Mk.N_Val.Phys.Temperature.Build;

namespace N_Val.Test_Learn.Operations;
public class ArithmeticsDemo
{
    [Test]
    public void HowToAdd() {
        var subj = Temperature.Kelvin(0);
        Assert.That(subj.Kelvin++, Is.EqualTo(0));
        Assert.That(subj.Kelvin, Is.EqualTo(1));
        Assert.That(++subj.Kelvin, Is.EqualTo(2));

        var avgMay = Temperature.Celsius(19.52);
        var avgJune = Temperature.Celsius(23.77);
        var avgJuly = Temperature.Celsius(28.83);
        var avgAug = Temperature.Celsius(26.79);
        var avgSep = Temperature.Celsius(18.15);
        var effectiveVegetativeSum = Temperature.Celsius(
            avgMay.Celsius + avgJune.Celsius + avgJuly.Celsius + avgAug.Celsius + (avgSep.Celsius / 2));
        Assert.That(effectiveVegetativeSum.Celsius, Is.GreaterThan(100));
    }

    [Test]
    public void HowToSubtract() {
        var subj = Temperature.Kelvin(273.15);
        Assert.That(subj.Celsius--, Is.EqualTo(0));
        Assert.That(subj.Celsius, Is.EqualTo(-1));
        Assert.That(--subj.Celsius, Is.EqualTo(-2));

        var kettleBoilingPrev = Temperature.Fahrenheit(197.4);
        var kettleBoiling = Temperature.Fahrenheit(184.1);
        // For every 500 ft elevation, water's boiling point is lowered by ~0.5 °C.
        var feetAscend = (kettleBoilingPrev.Celsius - kettleBoiling.Celsius) * 1000;
        Assert.That(feetAscend, Is.EqualTo(7000).Within(400));
    }

    [Test]
    public void HowToMultiply() {
        const double quicksilverMeltdown = -38.83;
        var point = Temperature.Celsius(quicksilverMeltdown);
        point.Fahrenheit *= 7;
        Assert.That(point.Celsius, Is.LessThan(quicksilverMeltdown));

        point = Temperature.Celsius(quicksilverMeltdown);
        point.Kelvin *= 7;
        Assert.That(point.Celsius, Is.GreaterThan(0));
    }

    [Test]
    public void HowToDivide() {
        var minHeating = Temperature.Celsius(30);
        var maxHeating = Temperature.Celsius(90);
        var heatingStep = Temperature.Celsius(10);

        var levels = 1 + ((maxHeating.Celsius - minHeating.Celsius) / heatingStep.Celsius);
        Assert.That(levels, Is.EqualTo(7));
    }

    [Test]
    public void HowToGetRemainder() {
        var sciFactor = Temperature.Fahrenheit(2.71);
        var experimentalValue = Temperature.Fahrenheit(10.84012);

        var delta = experimentalValue.Fahrenheit % sciFactor.Fahrenheit;

        Assert.That(delta, Is.EqualTo(0).Within(0.01));
    }
}
