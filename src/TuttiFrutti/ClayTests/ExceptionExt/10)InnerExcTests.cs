namespace ClayTests.ExceptionExt;
public class InnerExcTests
{
    [Test]
    public void NoInnerException() {
        var exc = Assert.Throws<NotImplementedException>(() => NotImplemented.Throw(nameof(NoInnerException)));
        Assert.That(exc?.Message, Is.EqualTo(nameof(NoInnerException)));
        Assert.That(exc?.InnerException, Is.Null);
    }

    [Test]
    public void WithInnerException() {
        try {
            var intentionalFail = int.Parse(long.MaxValue.ToString());
        } catch (OverflowException exc) {

            var wrap = Assert.Throws<InvalidOperationException>(() => InvalidOperation.Throw($"test {exc.GetType().FullName}", exc));
            Assert.That(wrap, Is.Not.Null);
            Assert.That(wrap?.InnerException?.GetType(), Is.EqualTo(typeof(OverflowException)));
        }
    }

    [Test]
    public void InnerInInner() {
        var exc = Assert.Throws<ArgumentException>(() =>
            Argument.Throw("A",
                Argument.New("B",
                    Argument.New("C"))));

        var inner = exc?.InnerException?.InnerException;
        Assert.That(inner?.Message, Is.EqualTo("C"));
    }
}