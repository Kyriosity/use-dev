using AbcStoppers.Guards;

namespace ExtensionsTests.Guards;
public class RangeGuards : AbcExtNUnit.AssertOnAssign.Defined_Errors_Vars
{
    [SyntaxDemo]
    public void NumericRange() {
        const int two = 2;
        True = two == two.NotOutRange(1, 5);
        True = Math.PI == Math.PI.NotOutRange(1, 5);
        Assert.Throws<ArgumentOutOfRangeException>(() => two.NotOutRange(3, 5));

        Assert.Throws<ArgumentOutOfRangeException>(() => two.NotOutRange(5, 3));
    }
}