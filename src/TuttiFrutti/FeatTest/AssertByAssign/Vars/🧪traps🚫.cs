namespace FeatTest.AssertByAssign.Vars;
public class Traps : Basal
{
#if DEBUG
    [Test]
#endif
    public void NullMustBeTypeSpecific() {
        int? nulledWhole = null;
        double? nulledFloat = null;

        Eq[null] = nulledWhole; // ✅
        Eq[null] = nulledFloat; // ✅

        Eq[1] = null; // ❌👈 will not run the check but will not throw fixture exception unless next check following
        Eq[1] = 1;
    }
}
