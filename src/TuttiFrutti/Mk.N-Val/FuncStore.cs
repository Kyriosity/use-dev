using System.Numerics;
namespace Mk.N_Val;

public interface IFuncStore<U> where U : Enum // ToDo: Refactor to separate module
{
    Func<N, N> For<N>(U from, U to) where N : INumber<N>;
}
