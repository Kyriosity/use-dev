namespace ClayTests.Errors.Conditional.CustomExceptions;
public class NArg_DuplicatedDemo
{
    [Test]
    public void ProveUnique() {
        var three = 3;
        DuplicatedArguments.ThrowIfAny(1, 2, three, 4, 5);
        Assert.Throws<DuplicatedArguments>(() => DuplicatedArguments.ThrowIfAny(1, 2, three, 4, 5, three));
        Assert.Throws<DuplicatedArguments>(() => DuplicatedArguments.ThrowIfAny(1, 2, 3, 4, 5, 3, 3, 2, 1, 1, 1));

        const string copyElem = "Abc";
        DuplicatedArguments.ThrowIfAny(copyElem, "Def", "Yyy", "Rrr", "RRR", "Www");
        Assert.Throws<DuplicatedArguments>(() => DuplicatedArguments.ThrowIfAny(copyElem, "Def", "Yyy", "Rrr", copyElem, "RRR", "Www"));
    }

    [Test]
    public void PlanetWithSattelites() {
        const string theJupiter = "Jupiter"; var moonIII = "Ganymede"; var moonIV = "Callisto";
        var moonI = "Io"; var moonII = "Europe"; var moonV = "Amalthea"; var moonVI = "Himalia";
        var moonXIV = "Theme"; var moonVII = "Elara"; var moonVIII = "Pasiphae"; var moonXI = "Carme";

        DuplicatedArguments.ThrowIfAny(theJupiter, moonIII, moonIV, moonI, moonII, moonV, moonVI, moonXIV, moonVII, moonVIII, moonXI);

        var exc = Assert.Throws<DuplicatedArguments>(() => DuplicatedArguments.ThrowIfAny(
            theJupiter, moonIII, moonIV, moonII, moonII, moonV, moonVI, moonXIV, moonVII, moonVIII, moonXI));
        Assert.That(exc.Message, Contains.Substring(moonII));
        Assert.That(exc.Message, Contains.Substring(nameof(moonII)));
    }

    [Test]
    public void ProveLooseDuplicate() {
        Assert.Throws<DuplicatedArguments>(() =>
            DuplicatedArguments.ThrowIfAny(DuplicatedArguments.LooseEqual, "check", "name A", "Name A", "   name   A   "));
        Assert.Throws<DuplicatedArguments>(() =>
            DuplicatedArguments.ThrowIfAny(DuplicatedArguments.LooseEqual, "check", " Name A", "   name   A   "));

        DuplicatedArguments.ThrowIfAny(DuplicatedArguments.LooseEqual, "check", "name A", "name B");
    }
}