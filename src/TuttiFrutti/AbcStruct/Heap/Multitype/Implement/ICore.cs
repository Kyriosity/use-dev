namespace AbcStruct.Heap.Multitype.Implement;
public interface ICore
{

    virtual bool Find<TId, T>(TId id, out T? val) where TId : notnull {
        var pointer = Qualify<T>();

        if (Dir.TryGetValue(Qualify<T>(), out var available)) {
            var dict = (IDictionary<TId, T?>)available;
            if (dict.TryGetValue(id, out val))
                return true;
        }
        val = default; return false;
    }

    virtual bool Add<TId, T>(TId id, T? val) where TId : notnull {
        var pointer = Qualify<T>();

        if (!Dir.TryGetValue(pointer, out var available)) {
            Dir[pointer] = new Dictionary<TId, T?>() { [id] = val };
            return true;
        }

        var dict = (IDictionary<TId, T?>)available;
        if (dict.ContainsKey(id))
            return false;

        dict[id] = val;
        return true;
    }

    virtual bool Remove<TId, T>(TId id) where TId : notnull {
        var pointer = Qualify<T>();
        if (Dir.TryGetValue(pointer, out var available)) {
            var dict = (IDictionary<TId, T?>)available;
            if (dict.ContainsKey(id)) {
                if (1 == dict.Count)
                    Dir.Remove(pointer);
                else
                    dict.Remove(id);

                return true;
            }
        }
        return false;
    }

    protected IDictionary<string, IEnumerable> Dir { get; }

    protected static string Qualify<T>() =>
        typeof(T).FullName ?? Argument.Throw($"{nameof(T)} has no full name");

}
