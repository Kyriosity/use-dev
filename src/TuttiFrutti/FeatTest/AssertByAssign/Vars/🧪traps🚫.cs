namespace FeatTest.AssertByAssign.Vars;
public class Traps : Arrange
{
#if DEBUG
    [Test]
#endif
    public void NullMustBeTypeSpecific() {
        int? nulledWhole = null;
        double? nulledFloat = null;

        Eq[nulledWhole] = nulledWhole; // ✅
        Eq[null] = nulledFloat; // ✅

        Eq[1] = null; // ❌👈 will not run the check but will not throw fixture exception unless next check following
        Eq[1] = 1;
    }
}