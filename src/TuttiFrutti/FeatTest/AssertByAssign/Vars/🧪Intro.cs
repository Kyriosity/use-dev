// ReSharper disable InconsistentNaming

namespace FeatTest.AssertByAssign.Vars;
public class Intro : Arrange
{
#if DEBUG
    [Test]
#endif
    public void Numbers() {
        int negVal = -9;

        Eq[110] = 2220;
        Eq[123] = 22 + 1000;
        Lt[-5] = negVal;

        Func<int, int, bool> within = (left, right) => true;

        Within[(1, 3)] = 1; // NOT -> OUTSIDE
        //PlusMinus[1]// also %

    }
}