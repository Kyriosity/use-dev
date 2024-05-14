namespace ClayTests.Chrono.Events.TDD;
public class BigScale
{
    [Test]
    public void UniverseChronology() {
        var univ = Hist.Eon;

        var sample = univ.Ago.circa().Megaannum(1);

        var bigBang = univ.Centamillenniuum(0);
        var beginDarkAges = univ.circa().Millennium(370);

        var galaxiesObserved = univ.circa().Megaannum(329);

        var firstStars = univ.circa(10).Megaannum(400);

        var endDarkAges = univ.Billion(1);

        var formedSolarSystem = univ.Megaannum(9_200);
        var beginDarkEnergyDomination = univ.Megaannum(9_800);

        var present = univ.circa().Millennium(13_770_000); // 13.77 billion (10x9) years

        var farFuture = univ.circa().Billion(100_000); // Big Crunch or Big Chill
    }

    [Test]
    public void EarthHistory() {
        var ago = Hist.Geo.Ago.circa();

        var formedMilkyWay = ago.Megaannum(13_600);
        var formedSun = ago.Megaannum(4_630);
        var formedEarth = ago.Megaannum(4_543);

        var explosionCambrian = ago.Megaannum(539);

        var beginHadean = ago.Millennium(4_567);
        var beginArchean = ago.Millennium(4_031);
        var beginProterozoik = ago.Millennium(2_500);
        var beginPhanerozoic = ago.Millennium(539);

        var appearModernHumans = ago.Millennium(300);

        var beginLastGlacialPeriod = ago.Millennium(115);
        var endLastGlacialPeriod = ago.Millennium(12);
    }

    [Test]
    public void AncientHistory() {
        var BCE = Era.BeforeCommon;

        var earlyBronzeAge = BCE.Year(3_300);
        var usedEgyptianHieroglyphs = BCE.Year(3_200);
        var earlyWriting = BCE.Millennium(3);
        var preDynasticChina = BCE.circa().Year(2_800);
        var existsAegeanCivilization = BCE.Year(2_700);
        var existsIndusCivilization = BCE.Year(2_600);
        var builtGreatPyramidOfGiza = BCE.Year(2_500);
        var formedAkkadianEmpire = BCE.circa(100).Year(2_200);

        var middleBronzeAge = BCE.Millennium(2);
        var lateBronzeAge = BCE.Year(2_600);

        var fallBabylon = BCE.circa().Year(1_500);
        var fallTroy = BCE.circa(90).Year(1_200);

        var collapseBronzeAge = BCE.Year(1_200);

        var abandonedNichoria = BCE.circa(50).Year(1_100);

        var foundRome = BCE.At.April(21).Year(753);  // 21 Απριλίου 753 π.Χ
        var firstOlympicGames = BCE.Year(776);
        var lifeHomer = BCE.circa().Century(8);

        var bornLeonidasI = BCE.circa().Year(540);
        var bornAthenianDemocracy = BCE.Year(510);

        var bornAristotelis = BCE.circa().Year(384);
        var bornhAlexTheGreat = BCE.At.circa().July(20).Year(356);

        var CE = Era.Common;
        var lateAntiquity = CE.circa(10).Year(300);
        var fallRome = CE.Year(476); // 476 μ.Χ.
        var endClassicAntiquite = CE.Year(600);
    }
}
