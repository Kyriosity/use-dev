namespace ClayTests.Errors;
public class ShortcutTests
{
    public static void WILL_NOT_COMPILE() {
        //throw new InvalidOperation();
        //throw new InvalidOperation("message");
        //throw new NotImplemented();
        //throw new NotSupported("test");
    }

    [Test]
    public void System() {
        var exc = Assert.Throws<NotImplementedException>(() => NotImplemented.Throw());
        Assert.That(exc?.Message, Is.Empty);


        var inOp = Assert.Throws<InvalidOperationException>(() => InvalidOperation.Throw(""));
        Assert.That(inOp?.Message, Is.Empty);

        var noSup = Assert.Throws<NotSupportedException>(() => NotSupported.Throw(nameof(ShortcutTests)));
        Assert.That(noSup?.Message, Is.EqualTo(nameof(ShortcutTests)));
    }

    [Test]
    public void Custom() {
        Assert.Throws<EntityNotFound>(() => EntityNotFound.Throw());
        Assert.Throws<UniqueConstraint>(() => UniqueConstraint.Throw("The same key exists"));
    }
}
