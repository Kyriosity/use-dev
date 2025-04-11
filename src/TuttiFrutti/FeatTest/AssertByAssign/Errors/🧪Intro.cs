// ReSharper disable InconsistentNaming

namespace FeatTest.AssertByAssign.Errors;
public class Intro : Basal
{
    [Test]
    public void Functions_MethodsWithReturn() {
        _ = DivideBy(2);
        Error = DivideByZeroException => DivideBy(0);
        Error = ArithmeticException => DivideBy(0);
        Error = SystemException => DivideBy(0); // for demo only, bad practice of generalizing exceptions

        // Error = ArgumentException => DivideBy(0); 👈 test will fail

        Error = ArgumentException => Dummy.ThrowNotReturnIf(true);
        // Error = ArgumentException => ThrowNotReturnIf(false); 👈 will fail
    }

    [Test]
    public void Procedures_VoidMethods() {
        // Err instead of Error because of technical restrictions
        Err = InvalidOperationException => InvalidAction(5);
        // Err = ArgumentException => InvalidAction(5); 👈 will fail

        Increment(200);
        Err = OverflowException => Increment(byte.MaxValue);
    }

    [Test]
    public void PropertiesThatThrow() {
        Error = FieldAccessException => Dummy.ErrorGetter;
        Error = Exception => Dummy.ErrorGetter; // will work but generalization is a bad practice
        //Error = Exception => Dummy.Ok; // will fail

        // expression trees don't like assignment
        //Error = NotImplementedException => Dummy.SetFail = "set to cause exception";
        // ... here is a workaround
        var wrap = () => Dummy.SetFail = "set to cause exception";
        Error = NotImplementedException => wrap();
    }

    [Test]
    public void PossibleError() {
        OkOrError = ArithmeticException => DivideBy(0);
        OkOrError = ArithmeticException => DivideBy(1);

        OkOrErr = OverflowException => Increment(byte.MaxValue);
        OkOrErr = OverflowException => Increment(5);
    }
}
