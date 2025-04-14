namespace FeatTest.AssertByAssign;
public class Demo_Vars_Numbers : Basal
{
    [SyntaxDemo]
    public void Intro() { // tribute to ALGOL68/Fortran
        const int Four = 4;

        Eq[Four] = 2 * 2;
        Eq[-5.55] = IdentityMap(-5.550);
        Not[3] = Math.PI;

        Gt[7] = IdentityMap(7);
        GE[7] = IdentityMap(10.123);

        LE[1] = -100.01;
        Lt[1] = 2;
    }

    [SyntaxDemo]
    public void Range() {
        Within[(Math.PI - 0.005, Math.PI + 0.01)] = 50 / 16;
        Outside[(7, 10.123)] = 1;
    }

    [SyntaxDemo]
    public void Strings() {

    }
}
