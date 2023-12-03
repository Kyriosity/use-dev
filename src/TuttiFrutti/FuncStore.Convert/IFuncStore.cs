global using Abc.Err.Sys;
using System.Numerics;

namespace FuncStore.Convert;

public interface IFuncStore<U> where U : Enum, IConvertible // ToDo: more generic FuncStore<T>

{
    Func<N, N> For<N>(U from, U to) where N : INumber<N>;
}

public class FuncStoreStub<U> : IFuncStore<U> where U : Enum // ToDo: move to project
{
    public Func<N, N> For<N>(U from, U to) where N : INumber<N> => NotImplemented.Throw(from, to);
}