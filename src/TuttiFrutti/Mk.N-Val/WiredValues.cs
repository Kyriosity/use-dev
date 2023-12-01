using N_Val;
using System.Numerics;

namespace Mk.N_Val;
public abstract class WiredValues<T, U> : IValueByUnit<T, U> where U : Enum
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

    protected abstract T Convert(U unit);
}

public class FuncWiredValues<N, U, F> : WiredValues<N, U>
    where N : INumber<N> where U : Enum where F : IFuncStore<U>, new()
{
    protected IFuncStore<U> Funcs { get; } = new F();

    protected override N Convert(U unit) => Funcs.Between<N>(_original.unit, unit)(_original.value);
}