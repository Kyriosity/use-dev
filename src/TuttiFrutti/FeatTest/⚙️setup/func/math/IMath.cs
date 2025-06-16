namespace FeatTest.setup.func.math;
interface IMath
{
    internal double Do<N1, N2>(N1 argA, N2 argB) where N1 : INumber<N1> where N2 : INumber<N2>;
}
