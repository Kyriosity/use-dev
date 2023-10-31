using Mk.N_Val.Phys.Temperature.Build;
using Mk.N_Val.Phys.Temperature.Const;
using N_Val.Phys.Temperature;
using N_Val.Test_Learn.Setup;
using System.Numerics;

namespace N_Val.Test_Learn.Basics;

public class IndexerTests
{
    [TestCaseSource(typeof(Providers), nameof(Providers.MutitypeNumerics))]
    [Ignore("ToDo: next")]
    public void AccessByIndex<N>(ITempEdit<N> temperature) where N : INumber<N> {
        var absolute = temperature[In.Kelvin];
        Assert.That(absolute, Is.GreaterThan(N.Zero));
        temperature[In.Kelvin] = absolute;
        temperature[In.Kelvin]++;

        var closed = (ITemperature<N>)temperature;
#if FALSE // COULD_COMPILE
        closed[In.Kelvin] = absolute;
#endif
        Assert.That(closed[In.Kelvin], Is.EqualTo(temperature[In.Kelvin]));
    }

    [TestCase(In.Celsius, -20.2), TestCase(In.Fahrenheit, 451), TestCase(In.Kelvin, 123_500_700_999)]
    public void IndexBySuppliedVariable<N>(In unit, N val) where N : INumber<N> {
        var holder = Temperature.Kelvin(N.Zero);
        holder[unit] = val;
        Assert.That(holder[unit], Is.Not.EqualTo(N.Zero));
    }

    [Test]
    public void ShortenIndex() {
        var temperature = Temperature.Celsius(961.8);
        var absoluteValue = temperature[K];
        temperature[C]++;
        Assert.That(temperature, Has.Property(nameof(Temperature.Kelvin)));

        Assert.That(Melting.Platinum[C], Is.LessThan(Melting.Tungsten[C]));

        var hottestCreated = Plasma.QuarkGluon.CERN_2012[K];
        Assert.That(hottestCreated, Is.GreaterThan(Sun.Core[K]));

    }

    private readonly In K = In.Kelvin;
    private readonly In C = In.Celsius;
    private readonly In F = In.Fahrenheit;
}