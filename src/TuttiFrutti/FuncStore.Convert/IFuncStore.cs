using System.Numerics;

namespace FuncStore.Conversion;

public interface IFuncStore { }

public interface IFuncStore<U> : IFuncStore where U : Enum, IConvertible // ToDo: more generic FuncStore<T>
{
    Func<N, N> For<N>(U from, U to) where N : INumber<N>;
}

public class FuncStore<U> : IFuncStore<U> where U : Enum // ToDo: move to project
{
    public Func<N, N> For<N>(U? from, U? to) where N : INumber<N> => AbcExt.Errors.Sys.NotImplemented.Throw(from, to);
}