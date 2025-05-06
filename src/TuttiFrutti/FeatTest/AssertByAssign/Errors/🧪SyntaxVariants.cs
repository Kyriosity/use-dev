using AbcStoppers.Errors.Argument;

namespace FeatTest.AssertByAssign.Errors;
public class SyntaxVariants : Basal
{
    [Test]
    public void AcronymsPossible() {
        Error = DivideByZeroException => DivideBy(0);
        Error = DivideByZero => DivideBy(0);

        Error = ArithmeticException => DivideBy(0);
        Error = Arithmetic => DivideBy(0);

        Error = ArgumentException => Dummy.ThrowNotReturnIf(true);
        Error = Argument => Dummy.ThrowNotReturnIf(true);
    }

    [Test]
    public void QualifyFullOrPartialNamespace() {
        // double underscore to prevent collisions
        Error = System__FieldAccessException => Dummy.ErrorGetter;

        var wrap = (string arg) => {
            DuplicatedArgument.Throw("for demo only");
            return true;
        };
        Error = AbcCommu__Errors__Argument__DuplicatedArgument => wrap("test it");
    }
}
