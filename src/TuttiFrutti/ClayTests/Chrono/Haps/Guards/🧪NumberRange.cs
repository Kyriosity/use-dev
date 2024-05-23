namespace ClayTests.Chrono.Haps.Guards;
public class NumberRange
{
    [Test]
    public void Years() {
        var era = Era.Common;
        var hap = era.Year(2024);

        Assert.Throws<NotSet>(() => _ = hap.UnixYear);
    }
}
