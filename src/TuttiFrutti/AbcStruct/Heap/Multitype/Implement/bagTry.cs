using AbcStruct.Ops.Keyed.Multitype;

namespace AbcStruct.Heap.Multitype.Implement;

internal class bagTry<TId> : ITryOps<TId> where TId : notnull
{
    public bool Put<T>(TId id, T? val) {
        var pointer = Qualify<T>();

        if (!_dispatcher.TryGetValue(pointer, out var available)) {
            _dispatcher[pointer] = new Dictionary<TId, T?>() { [id] = val };
            return true;
        }

        var dict = (IDictionary<TId, T?>)available;
        if (dict.ContainsKey(id))
            return false;

        dict[id] = val;
        return true;
    }

    public bool Take<T>(TId id, out T? val) {
        if (!Read<T>(id, out val))
            return false;

        _ = Remove<T>(id);
        return true; ;
    }

    public bool Read<T>(TId id, out T? val) {
        if (_dispatcher.TryGetValue(Qualify<T>(), out var available)) {
            var dict = (IDictionary<TId, T?>)available;
            if (dict.TryGetValue(id, out val))
                return true;
        }

        val = default; return false;
    }

    private bool Remove<T>(TId id) {
        if (_dispatcher.TryGetValue(Qualify<T>(), out var available)) {
            var dict = (IDictionary<TId, T?>)available;
            if (dict.ContainsKey(id)) {
                dict.Remove(id);
                return true;
            }
        }

        return false;
    }

    private readonly IDictionary<string, IEnumerable> _dispatcher = new Dictionary<string, IEnumerable>();

    private static string Qualify<T>() =>
        typeof(T).FullName ?? Argument.Throw($"{nameof(T)} has no full name");
}
