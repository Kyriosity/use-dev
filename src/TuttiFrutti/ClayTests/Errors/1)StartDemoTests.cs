namespace ClayTests.Errors;
public class StartDemoTests
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
    public void ShortcutInstantiate() {
        var exc = EntityNotFound.New();
        Assert.That(exc.GetType(), Is.EqualTo(typeof(EntityNotFound)));

        var argExc = Argument.New("sample arg exception", UniqueConstraint.New("Name <...> already reserved in the domain [...]"));
        Assert.Throws<ArgumentException>(() => throw argExc);
    }

    [Test]
    public void System() {
        var exc = Assert.Throws<NotImplementedException>(() => NotImplemented.Throw());
        Assert.That(exc?.Message, Is.Empty);

        var inOp = Assert.Throws<InvalidOperationException>(() => InvalidOperation.Throw(""));
        Assert.That(inOp?.Message, Is.Empty);

        var noSup = Assert.Throws<NotSupportedException>(() => NotSupported.Throw(nameof(StartDemoTests)));
        Assert.That(noSup?.Message, Is.EqualTo(nameof(StartDemoTests)));

        var argExc = Assert.Throws<ArgumentException>(() => Argument.Throw(747));
        Assert.That(argExc?.Message, Is.EqualTo("747"));

        var argNull = Assert.Throws<ArgumentNullException>(() => ArgumentNull.Throw("<NAME OF ARG_PROTO>"));
    }

    [Test]
    public void Custom() {
        Assert.Throws<UniqueConstraint>(() => UniqueConstraint.Throw("The same key <...> exists"));
        Assert.Throws<EntityNotFound>(() => EntityNotFound.Throw($"unid: ..., name:  ..."));
    }
}
