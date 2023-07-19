using System.Numerics;
using System.Runtime.CompilerServices;

namespace N_Val;
public abstract class WiredValues<N> : IFacetValue where N : INumber<N>
{
    private (N value, string unit) _original;

    protected readonly Dictionary<(string from, string to), Func<N, N>> _convert = new();

    private readonly Dictionary<string, N> _cache = new();

    protected virtual N Get([CallerMemberName] string unit = "") {
        if (unit == _original.unit)
            return _original.value;

        if (!_cache.ContainsKey(unit))
            _cache[unit] = _convert[(_original.unit, unit)](_original.value);

        return _cache[unit];
    }
    protected void Set(N value, [CallerMemberName] string unit = "") {
        _cache.Clear();
        _original.value = value;
        _original.unit = unit;
    }
}
