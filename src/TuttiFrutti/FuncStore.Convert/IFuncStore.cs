
namespace FuncStore.Conversion;

public interface IFuncStore;

public interface IFuncStore<in U> : IFuncStore where U : Enum, IConvertible // ToDo: more generic FuncStore<T>
{
    Func<N, N> For<N>(U from, U to) where N : INumber<N>;
}

public class FuncStore<U> : IFuncStore<U> where U : Enum // ToDesign: move to project
{
    public Func<N, N> For<N>(U? from, U? to) where N : INumber<N> => NotImplemented.Throw($"{from} -> {to}");
}