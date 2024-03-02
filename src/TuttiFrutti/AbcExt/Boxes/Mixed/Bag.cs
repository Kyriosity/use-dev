using AbcExt.Errors.Sys;
using AbcExt.Wording;
using System.Collections;
using System.Runtime.CompilerServices;

namespace AbcExt.Boxes.Mixed;
public class Bag : IHeap
{
    private readonly IDictionary<string, IEnumerable> _dispatcher = new Dictionary<string, IEnumerable>();

    public void Put<TKey, TVal>(TKey id, TVal? value) where TKey : notnull {
        var pointer = Qualify<TVal>();

        if (_dispatcher.TryGetValue(pointer, out var available))
            ((IDictionary<TKey, TVal?>)available)[id] = value;
        else
            _dispatcher[pointer] = new Dictionary<TKey, TVal?>() { [id] = value };
    }

    public bool Pick<TId, TVal>(TId id, out TVal? value) where TId : notnull {
        var pointer = Qualify<TVal>();

        if (_dispatcher.TryGetValue(pointer, out var available)) {
            var dict = (IDictionary<TId, TVal>)available;
            if (dict.TryGetValue(id, out value))
                return true;
        }

        value = default; return false;
    }

    public void EnsureNone<TId, TVal>(TId id) {
        var pointer = Qualify<TVal>();

        if (_dispatcher.TryGetValue(pointer, out var available)) {
            var dict = (IDictionary<TId, TVal>)available;
            _ = dict.Remove(id);
        }
    }

    private static string Qualify<TVal>([CallerMemberName] string caller = Arg.NotSubmitted) {
        var pointer = typeof(TVal).FullName ?? Argument.Throw($"{caller}(): {nameof(TVal)} has no name");
        return pointer;
    }
}
