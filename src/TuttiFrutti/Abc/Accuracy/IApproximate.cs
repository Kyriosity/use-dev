namespace Abc.Accuracy;

public interface IApproximate<T>
{
    T circa();
}
public interface IApproximate<T, N> : IApproximate<T>
    where N : INumber<N>
{
    T circa(N delta);
}
