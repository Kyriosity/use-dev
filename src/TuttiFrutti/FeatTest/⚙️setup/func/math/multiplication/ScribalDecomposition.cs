using AbcStoppers.Errors.Sys;
using ISie.Number.Calc;
using ISie.Number.Is;

namespace FeatTest.setup.func.math.multiplication;
internal class ScribalDecomposition : IMath
{
    public double Do<N1, N2>(N1 argA, N2 argB) where N1 : INumber<N1> where N2 : INumber<N2> {
        var left = double.CreateChecked(argA);
        var right = double.CreateChecked(argB);

        Argument.ThrowIfAny(n => n.Not.Integer, left, right);

        if (left is 0 | right is 0)
            return 0;

        bool negate = left is < 0 ^ right is < 0;
        left = left.Abs(); right = right.Abs();
        if (left > right)
            (left, right) = (right, left);

        double sum = 0;
        do {
            if (left.Is.Integer.Odd)
                sum += right;

            left = (left / 2).Truncate();
            right = right * 2;
        } while (left is not 0);

        return negate ? -sum : sum;
    }
}
