namespace ClayTests.ExceptionExt;
public class IntroDemo
{
    public static void WILL_NOT_COMPILE() {
        //throw new InvalidOperation();
        //throw new InvalidOperation("message");
        //throw new NotImplemented();
        //throw new NotSupported("test");
        //throw new Argument(1, 2, 3);
        //throw new Argument("can't ", null);
    }

    [Test]
    public void System() {
        var exc = Assert.Throws<NotImplementedException>(() => NotImplemented.Throw("Test of exception itself"));
        Assert.That(exc?.Message, Is.Not.Empty);

        var inOp = Assert.Throws<InvalidOperationException>(() => InvalidOperation.Throw(""));
        Assert.That(inOp?.Message, Is.Empty);

        var noSup = Assert.Throws<NotSupportedException>(() => NotSupported.Throw(nameof(IntroDemo)));
        Assert.That(noSup?.Message, Is.EqualTo(nameof(IntroDemo)));

        var argNull = Assert.Throws<ArgumentNullException>(() => ArgumentNull.Throw("<NAME OF ARG_PROTO>"));
    }

    [Test]
    public void NonStringMessage() {
        var plane = 747;
        var argExc = Assert.Throws<ArgumentException>(() => Argument.Throw(plane));

        Assert.That(argExc?.Message, Does.Contain(nameof(plane)));
        Assert.That(argExc?.Message, Does.Contain("747"));

        var exc = Assert.Throws<EntityNotFound>(() => EntityNotFound.Throw(new Dummy()));
        Assert.That(exc?.Message, Does.Contain(Dummy.ToStringProduced));
    }


    [Test]
    public void Custom() {
        Assert.Throws<UniqueConstraint>(() => UniqueConstraint.Throw("The same key <...> exists"));
        Assert.Throws<EntityNotFound>(() => EntityNotFound.Throw($"unid: ..., name:  ..."));

        Assert.Throws<DuplicatedArgument>(() =>
            DuplicatedArgument.Throw("Repeated IDs found: <..., ...>"));
    }

    private class Dummy
    {
        public const string ToStringProduced = "TO_STRING_TEST_MESSAGE";
        public override string ToString() => ToStringProduced;
    }
}