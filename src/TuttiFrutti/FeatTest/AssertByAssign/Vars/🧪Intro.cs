// ReSharper disable InconsistentNaming

namespace FeatTest.AssertByAssign.Vars;
public class Intro : Basal
{
    [SyntaxDemo]
    public void Numbers() {
        //Eq[4] = 2 * 2;
        //Eq[5] = 2 * 2; // will fail
    }
}