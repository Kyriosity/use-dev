namespace FeatTest.AssertByAssign.Vars;
public class Traps : Basal
{
#if DEBUG
    [Test]
#endif
    public void FrameworkLimitations() {
        int? nulledWhole = null;
        double? nulledFloat = null;

        Eq[1] = nulledWhole; // ✅
        Eq[1] = nulledFloat; // ✅

        Eq[4] = null; // ❌👈 must throw fixture exception

    }
}
