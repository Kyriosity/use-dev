using AbcChrono.Timescales;

namespace ExtensionsTests.Chrono.Haps.Guards;
public class NumberRange
{
    [Test]
    public void NoZeroDate() {
        var at = Era.Common.At;
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = at.January(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = at.circa().August(0));
    }


    [Test]
    public void NoZeroYears() {
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = Era.Common.Year(0));
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = Era.BeforeCommon.circa().Year(0));

        Era.Holocene.Year(0);
        Era.Holocene.circa().Year(0);
    }

    [Test]
    public void LeapYears() {
        var at = Era.Common.At;
        Assert.That(at.February(29).Year(2024), Is.Not.Null);

        Assert.Throws<ArgumentOutOfRangeException>(() => _ = at.February(29).Year(2023));
    }

    [Test]
    public void TrespassingDates() {
        var at = Era.Common.At;

        Assert.That(at.November(30).Year(2021), Is.Not.Null);
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = at.November(31).Year(2021));

        Assert.That(at.December(31).Year(2021), Is.Not.Null);
        Assert.Throws<ArgumentOutOfRangeException>(() => _ = at.December(32).Year(2021));

    }
}
