using MeasUnits.Names;
using MeasUnits.Names.Si;

namespace MeasUnits.Utils;
public static class Match
{
    private static readonly Heap.ITryOps<string> _cache = Bag.TryOnly.New();

    public static bool TryLoose<U>(string raw, out U? unit) where U : Enum {
        var match = Loose<U>(raw);
        unit = match.unit;
        return match.success;
    }

    public static (bool success, U? unit) Loose<U>(string raw) where U : Enum {
        if (_cache.Read(raw, out (bool success, U? unit) match))
            return match;

        match.success = Parse.Try<U>(raw, out match.unit);
        if (!match.success && FactoredAttribute.From(typeof(U)).Any())
            match.success = TryMetricMatch<U>(raw, out match.unit);

        if (match.success)
            _cache.Put(raw, match);

        return match;
    }

    private static bool TryMetricMatch<U>(string raw, out U? match) where U : Enum {
        match = default;
        var prefixed = _baseNames.SingleOrDefault(baseName => raw.EndsWith(baseName, StringComparison.InvariantCultureIgnoreCase));
        if (prefixed is null)
            return false;

        if (prefixed == raw)
            return Parse.Try<U>(Common.Base, out match);

        var extra = raw[..^prefixed.Length]; // shortcuts -> raw.Substring(0, raw.Length - prefixed.Length)
        return Parse.Try<U>(extra, out match);
    }

    private static readonly string[] _baseNames = [
        .. Base.NameAbbr.Keys.ToArray(),
        .. Names.Si.Derived.Base.NameAbbr.Keys.ToArray(),
        .. Names.Si.Accepted.Base.NameAbbr.Keys.ToArray()];
}