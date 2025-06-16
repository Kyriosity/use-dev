using AbcExtNUnit.Attributes.Case;
using FeatTest.setup.func.math;
using FeatTest.setup.func.math.multiplication;

namespace FeatTest.Demo;
public class AltMathOps : Arrange, IMath
{
    [SyntaxDemo]
    public void Intro() {
        Eq[20] = calc.Do(4, 5);
        Eq[20] = calc.Do(4.000, 5.000);
        Eq[20] = calc.Do((byte)4, 5.000f);
        Eq[20] = calc.Do(4m, (short)5); ;
        Eq[20] = calc.Do(4l, (sbyte)5m);
        Eq[20] = calc.Do(4l, 5UL);
    }


    [Many([0, 1], [446, 0], [1, 1], [1, 4], [2, 5], [47, 5], [-30, 28], [3_000, -72])]
    [Many([203_34.00, 5d], [-1_000_932_323, 5_332_196], [-334, -444])]

    public void Natural<N1, N2>(N1 argA, N2 argB) where N1 : INumber<N1> where N2 : INumber<N2> {
        Eq[proof.Do(argA, argB)] = calc.Do(argA, argB);
    }


    [Test]
    public void KnownErrors() {
        Error = ArgumentException => calc.Do(1.000_000_001, 1);
        Error = ArgumentException => calc.Do(1, double.NaN);
    }

    IMath calc = new ScribalDecomposition();
    IMath proof => this;
    double IMath.Do<N1, N2>(N1 argA, N2 argB)
        => double.CreateChecked(argA) * double.CreateChecked(argB);
}