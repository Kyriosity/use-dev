namespace ClayTests.Chrono.Events.TDD;
public class Syntax_Eras
{
    [Test]
    public void AnnualBenchmarks() {
        var CE = Era.Common;

        var endJustinianPlague = CE.Year(549);
        var discoveredAmericanIslands = CE.Year(1492);
        var fall_AppleOnNewton = CE.Year(1653);
        var spanDutchPaintingGoldenAge = CE.Century(17);
        var periodVictorian = CE.Century(19);
    }

    [Test]
    public void AnnualApproximateEvents() {
        var CE = Era.Common;

        var span_MiddleAges = CE.circa(500).Year(1000);
        var span_SciRevolution = CE.circa(60).Year(1600);

        var eruptionToba = Era.BeforeCommon.circa(300).Year(73_700);
    }

    [Test]
    public void MonthAndDays() {
        var at = Era.Common.At;

        var eruption_Vesuvium = at.October().Year(79);

        var fall_Constantinopole = at.May(29).Year(1453);

        var printGutenbergBible = at.February(23).Year(1455);
        var startMagellanVoyage = at.September(20).Year(1519);

        var born_Beavis = at.October(29).Year(1979);

        var nextPerihelionHalleyComet = at.July(28).Year(2061);
    }

    [Test]
    public void MonthAndDays_Circa() {
        var at = Era.Common.At;

        var born_RaffaelloSanzio_daUrbino = at.circa(4).April(2).Year(1483);

        var thisTestDesigned = at.circa().April(30).Year(2022);

        var everywhereSchoolHoliday = at.circa().July();
        var lastYear = everywhereSchoolHoliday.Year(2023);
    }

    [Test]
    public void AncientGreekPhilosophers() {
        var BCE = Era.BeforeCommon;

        var floruit_Heraclitus = BCE.circa(10).Year(500);

        var born_Pythagoras = BCE.circa().Year(570);
        var born_Xenophanes = BCE.circa().Year(570);

        var born_Socrates = BCE.Year(469);
        var born_Plato = BCE.circa().Year(427);

        var born_DiogenesTheCynic = BCE.circa(4).Year(408);
        var born_Aristotle = BCE.Year(384);
    }
}
