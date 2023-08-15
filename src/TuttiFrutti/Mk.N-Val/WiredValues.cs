using N_Val;
using System.Numerics;

namespace Mk.N_Val;
public abstract class WiredValues<N, U> : IFacetValue<N> where N : INumber<N> where U : Enum
{
    private (N value, U unit) _original;

    private readonly Dictionary<U, N> _cache = new();

    public virtual N Get(U unit) {
        if (unit.Equals(_original.unit))
            return _original.value;

        if (!_cache.ContainsKey(unit))
            _cache[unit] = Conversion.Calculate(_original.value, _original.unit, unit);

        return _cache[unit];
    }

    public N Get(out U unit) {
        unit = _original.unit;
        return _original.value;
    }
    public virtual void Set(N value, U unit) {
        _cache.Clear();
        _original.value = value;
        _original.unit = unit;
    }

    protected virtual IConversion<N, U> Conversion => new FunctionalConversion<N, U>();
}