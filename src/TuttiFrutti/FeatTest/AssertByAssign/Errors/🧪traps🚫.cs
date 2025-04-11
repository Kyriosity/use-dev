namespace FeatTest.AssertByAssign.Errors;
public class Traps : Basal
{
#if DEBUG
    [Test]
#endif
    public void CaseSensitiveViolation() {

        Error = Arithmetic => DivideBy(0); // ✅
        Error = ArithmeticException => DivideBy(0); // ✅
        Error = ArithmeticEXCEPTION => DivideBy(0); // ❌👈 will fail
        Error = ARITHMETICException => DivideBy(0); // ❌👈 will fail
    }

#if DEBUG
    [Test]
#endif
    public void NonExistingException() {
        Error = ThereIsNoSuchException => DivideBy(0); // ❌👈 will fail with DivideByZero
    }
}