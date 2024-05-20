using AbcExt.DataOps.Compare;

namespace ClayTests.ExceptionExt.Conditional.CustomExceptions;
public class NArg_DuplicatedDemo
{
    [Test]
    public void ProveUnique() {
        var three = 3;
        DuplicatedArgument.ThrowIfAny(1, 2, three, 4, 5);
        Assert.Throws<DuplicatedArgument>(() => DuplicatedArgument.ThrowIfAny(1, 2, three, 4, 5, three));
        Assert.Throws<DuplicatedArgument>(() => DuplicatedArgument.ThrowIfAny(1, 2, 3, 4, 5, 3, 3, 2, 1, 1, 1));

        const string copyElem = "Abc";
        DuplicatedArgument.ThrowIfAny(copyElem, "Def", "Yyy", "Rrr", "RRR", "Www");
        Assert.Throws<DuplicatedArgument>(() => DuplicatedArgument.ThrowIfAny(copyElem, "Def", "Yyy", "Rrr", copyElem, "RRR", "Www"));
    }

    [Test]
    public void PlanetWithSattelites() {
        const string theJupiter = "Jupiter"; var moonIII = "Ganymede"; var moonIV = "Callisto";
        var moonI = "Io"; var moonII = "Europe"; var moonV = "Amalthea"; var moonVI = "Himalia";
        var moonXIV = "Theme"; var moonVII = "Elara"; var moonVIII = "Pasiphae"; var moonXI = "Carme";

        DuplicatedArgument.ThrowIfAny(theJupiter, moonIII, moonIV, moonI, moonII, moonV, moonVI, moonXIV, moonVII, moonVIII, moonXI);

        var exc = Assert.Throws<DuplicatedArgument>(() => DuplicatedArgument.ThrowIfAny(
            theJupiter, moonIII, moonIV, moonII, moonII, moonV, moonVI, moonXIV, moonVII, moonVIII, moonXI));
        Assert.That(exc.Message, Contains.Substring(moonII));
        Assert.That(exc.Message, Contains.Substring(nameof(moonII)));
    }

    [Test]
    public void ProveLooseDuplicate() {
        Assert.Throws<DuplicatedArgument>(() =>
            DuplicatedArgument.ThrowIfAny(Equal.Loose(), "check", "name A", "Name A", "   name   A   "));
        Assert.Throws<DuplicatedArgument>(() =>
            DuplicatedArgument.ThrowIfAny(Equal.Loose(), "check", " Name A", "   name   A   "));

        DuplicatedArgument.ThrowIfAny(Equal.Loose(), "check", "name A", "name B");
    }

    [Test]
    public void SubmitEnumerable() {
        string[] items = ["Fe", "Cu", "Ar", "O2", "C2O", "Fe"];
        Assert.Throws<DuplicatedArgument>(() => DuplicatedArgument.ThrowIfAny(items));

        items = [" Water ", "iron", "  IRON  ", "calcium", "Calcium"];
        Assert.Throws<DuplicatedArgument>(() => DuplicatedArgument.ThrowIfAny(Equal.Loose(), items));
    }
}