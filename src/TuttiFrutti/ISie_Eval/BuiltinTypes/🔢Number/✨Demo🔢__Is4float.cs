using ISie.Number.Is;

namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_Float_Is : ArrangeWithNumbers
{

#if DEBUG
    [Test]
#endif
    public void Integral() {
        double probe = 3.238;

        //_ = probe.Is.Integer.Natural0;
        False = probe.Is.NaturalOr0.PowOf2;
        False = probe.Is.Integer.Odd;

        False = probe.Is.NaturalOr0.Odd;
        False = probe.Is.Integer.Even;
    }
}
