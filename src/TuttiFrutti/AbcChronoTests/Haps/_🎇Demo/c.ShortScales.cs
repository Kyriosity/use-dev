namespace ExtensionsTests.Chrono.Haps.Demo;
public class ShortScales
{
    [Test]
    public void HoloceneScale() {
        var era = Era.Holocene;

        var beginHolocen = era.Year(1);
        var endPleistocene = era.Year(300);
        var beginHoloceneEpoch = era.Year(300);
        var zeroJulianDay = era.Year(5287);
        var beginHebrewCalendar = era.Year(6240); // 3751 BC
        var beginKaliYuga = era.Year(6899);
        var beginMeghalayan = era.Year(7751); // last ice age
        var introJulianCalendar = era.Year(9956);
        var firstYearBC = era.Year(10_000); // Year zero at ISO 8601
        var beginCommonEra = era.Year(10_001); // 1 AD
        var startIslamicCalendar = era.Year(10_622);
        var introGregorianCalendar = era.Year(11_582);
        var beginJucheCalendar = era.Year(11_912);
        var beginUnixEpoch = era.Year(11_970);
        var year2024 = era.Year(12_024);
    }

    [Test]
    public void HoloceneCirca() {
        var era = Era.Holocene;

        var approachAristotleComet = era.circa().Year(9629); // 372-371 BC

        var beginMinoanCivilization = era.circa(100).Year(6900);
        var eruptionMinoanThera = era.circa(5).Year(8400);
    }
}
