namespace ExtensionsTests.Exceptions.Conditional;
public class NArg_NullDemo
{
    [Test]
    public void ProveAnyNull() {
        const ulong limit = ulong.MaxValue;
        var dummyMessage = "end of args";

        int? first = 1;
        ArgumentNull.ThrowIfAny(first, 2, 3, 4, 5, 6, Math.PI, limit, dummyMessage, this, Greek.Pi);

        var dummyObjRef = new object();
        ArgumentNull.ThrowIfAny(limit, "second arg", 3, dummyObjRef, true);

        dummyObjRef = null;
        var exc = Assert.Throws<ArgumentNullException>(() =>
            ArgumentNull.ThrowIfAny(limit, "second arg", 3, dummyObjRef, true));
        Assert.That(exc?.Message, Contains.Substring(nameof(dummyObjRef)));

        dummyMessage = null;
        Assert.Throws<ArgumentNullException>(() =>
            ArgumentNull.ThrowIfAny("complete", dummyMessage));
    }

    [Test]
    public void ProveAllNull() {
        int? nonsenseNum = null;
        ArgumentNull.ThrowIfEach("", nonsenseNum, null, 2, null, "info", new object());

        ArgumentNull.ThrowIfEach(null, null, null, "not null", null, null, null);
        ArgumentNull.ThrowIfEach(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

        var dummyObjRef = new object();
        var dummyMessage = "verbatim";
        int? counter = 3;
        ArgumentNull.ThrowIfEach(dummyObjRef, dummyMessage, counter);

        dummyObjRef = null;
        dummyMessage = null;
        ArgumentNull.ThrowIfEach(dummyObjRef, dummyMessage, counter);

        counter = null;
        var exc = Assert.Throws<ArgumentNullException>(() =>
            ArgumentNull.ThrowIfAny(dummyObjRef, dummyMessage, counter, nonsenseNum, null));
        Assert.That(exc?.Message, Contains.Substring(nameof(dummyObjRef)));
    }
}

