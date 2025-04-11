namespace FeatTest.AssertByAssign;
public class Demo_Vars : Basal
{
    [SyntaxDemo]
    public void Numbers() { // ALGOL68/Fortran fashion
        Eq[-5] = -5;
        Not[1] = 1;

        Gt[7] = 10;
        GE[7] = 15;

        LE[1] = 1;
        Lt[1] = 2;
    }
}
