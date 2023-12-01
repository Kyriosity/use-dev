using System.Numerics;
namespace Mk.N_Val;

public interface IFuncStore<U> : ISameConverter<U> where U : Enum { }

public interface ISameConverter<T>
{
    Func<N, N> Between<N>(T from, T to) where N : INumber<N>;
}

public interface IDiverseConverter<U> where U : Enum
{
    Func<N1, N2> Between<N1, N2>(U from, U to) where N1 : INumber<N1> where N2 : INumber<N2>;
}
