using Abc.Err.Sys;
using N_Val;
using System.Numerics;

namespace Mk.N_Val;
public class WiredValues<T, U> : IValueByUnit<T, U> where U : Enum
{
    protected (T value, U unit) _original;

    public T Get(out U unit) {
        unit = _original.unit;
        return _original.value;
    }

    public T Get(U unit) => unit.Equals(_original.unit) ? _original.value : Convert(unit);

    public virtual void Set(T value, U unit) {
        _original.value = value;
        _original.unit = unit;
    }

    protected virtual T Convert(U unit) => NotImplemented.Throw();
}

public class NumWiredValues<N, U, F> : WiredValues<N, U>
    where N : INumber<N> where U : Enum where F : IFuncStore<U>, new()
{
    protected IFuncStore<U> Funcs { get; } = new F();

    protected override N Convert(U unit) => Funcs.For<N>(_original.unit, unit)(_original.value);
}