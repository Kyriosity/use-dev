using Mk.N_Val.Phys.Temperature.Build;
using N_Val.Phys.Temperature;
using System.Numerics;

namespace N_Val.Test_Learn.Casting;
public class OpenCloseCastTests
{
    [Test]
    public void ForExample() {
        ITemp<int> oven = Temperature.Celsius(1000);

#if FALSE // COULD COMPILE
        oven.Fahrenheit = 451;
#endif

        Assert.That(oven, Has.Property(nameof(Temperature.Celsius)));
    }

    [Test]
    public void SupplyReturnDemo() {
        var measurementsFromWorldLabs = new List<ITempEdit<double>> {
            Temperature.Kelvin(315.23),
            Temperature.Celsius(5.55),
            Temperature.Kelvin(1.11),
            Temperature.Celsius(-20.031),
            Temperature.Fahrenheit(96.9),
            Temperature.Fahrenheit(2.231),
        };

        var calibration = MustBeSomeLogicComplexerThanLambdaOrLinq(measurementsFromWorldLabs);
        Assert.That(calibration, Has.Property(nameof(Temperature.Kelvin)));
    }

    private ITemp<N> MustBeSomeLogicComplexerThanLambdaOrLinq<N>(IEnumerable<ITemp<N>> points) where N : INumber<N> {
        var magicNumber = N.CreateChecked(7.77);
        //var res = points.Sum(x => x.Kelvin);
        return Temperature.Celsius(magicNumber);
    }
}

