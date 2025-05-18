using ISie.Number.Is;

namespace ISie_Eval.BuiltinTypes.Number;
public class Demo_Float_Is : ArrangeWithNumbers
{

#if DEBUG
    [Test]
#endif
    public void Intro() {
        double probe = 3.238;
        False = probe.Is.NaN;

        False = probe.Is.NaturalOr0;
        False = probe.Is.NaturalOr0;

        False = probe.Is.NaturalOr0.Odd;
        False = probe.Is.Integer.Even;
    }

#if DEBUG
    [Test]
#endif
    public void WhenIntegral() {
        False = negativeDbl.Is.Integer;
        True = negativeDbl.Not.Integer;
    }
}
