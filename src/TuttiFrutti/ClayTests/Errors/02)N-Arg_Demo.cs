using AbcExt.Errors.Shortcuts;
using System.Drawing;

namespace ClayTests.Errors;
public class NArg_Demo
{
    [Test]
    public void ReportArgumentsCallers() {
        const string dummy = "NOT_IN_OUTPUT";
        var dummyStruct = new Point(7, -12);

        var exc = Assert.Throws<ArgumentException>(() =>
            Argument.Throw("Motley args to be recorded by caller",
                dummyStruct, 1, dummy, this, true, "literal", long.MinValue, 3 + 5, () => double.Epsilon * Math.E));

        Assert.That(exc?.Message, Contains.Substring(nameof(dummy)));
        Assert.That(exc?.Message, Does.Not.Contains(dummy));

        Assert.That(exc?.Message, Contains.Substring("literal"));
        Assert.That(exc?.Message, Contains.Substring("this"));

        Assert.That(exc?.Message, Contains.Substring(nameof(dummyStruct)));
        Assert.That(exc?.Message, Does.Not.Contains(dummyStruct.ToString()));

        Assert.That(exc?.Message, Contains.Substring("Epsilon"));
    }

    [Test]
    public void CustomMultiparam() {
        const float measure = 2.22f;
        var varied = "info";
        var objRef = new object();

        var exc = Assert.Throws<MyCustomMultiaparamException>(() =>
             MyCustomMultiaparamException.Throw("report multiple params of various types",
                 objRef, "message", measure, varied, byte.MinValue, 7));

        Assert.That(exc?.Message, Is.Not.Empty);
    }
    class MyCustomMultiaparamException(string? message = "", Exception? inner = null)
        : Multiparameter<MyCustomMultiaparamException>(message, inner);
}

