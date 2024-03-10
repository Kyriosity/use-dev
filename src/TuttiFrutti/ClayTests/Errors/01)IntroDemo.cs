namespace ClayTests.Errors;
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
        var exc = Assert.Throws<NotImplementedException>(() => NotImplemented.Throw());
        Assert.That(exc?.Message, Is.Empty);

        var inOp = Assert.Throws<InvalidOperationException>(() => InvalidOperation.Throw(""));
        Assert.That(inOp?.Message, Is.Empty);

        var noSup = Assert.Throws<NotSupportedException>(() => NotSupported.Throw(nameof(IntroDemo)));
        Assert.That(noSup?.Message, Is.EqualTo(nameof(IntroDemo)));

        var argExc = Assert.Throws<ArgumentException>(() => Argument.Throw(747));
        Assert.That(argExc?.Message, Is.EqualTo("747"));

        var argNull = Assert.Throws<ArgumentNullException>(() => ArgumentNull.Throw("<NAME OF ARG_PROTO>"));
    }

    [Test]
    public void Custom() {
        Assert.Throws<UniqueConstraint>(() => UniqueConstraint.Throw("The same key <...> exists"));
        Assert.Throws<EntityNotFound>(() => EntityNotFound.Throw($"unid: ..., name:  ..."));

        Assert.Throws<DuplicatedArgument>(() =>
            DuplicatedArgument.Throw("Repeated IDs found: <..., ...>"));
    }
}
