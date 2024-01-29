using Abc.Ext.Boxes.Mixed;
using Abc.Ext.Xlat.Consts;
using Meas.Units.Metadata;
using Meas.Units.Names;
using Si = Meas.Units.Names.Si;

namespace Meas.Units.Utils;

public static class Match
{
    private static readonly IHeap _cache = new Bag();

    public static bool TryLoose<U>(string raw, out U? match) where U : Enum {
        if (_cache.Pick(raw, out match))
            return true;

        var success = Parse.Try<U>(raw, out match);
        if (!success && FactoredAttribute.From(typeof(U)).Any())
            success = TryMetricMatch<U>(raw, out match);

        if (success)
            _cache.Put(raw, match);

        return success;
    }

    private static bool TryMetricMatch<U>(string raw, out U? match) where U : Enum {
        match = default;
        var prefixed = _baseNames.SingleOrDefault(baseName => raw.EndsWith(baseName, StringComparison.InvariantCultureIgnoreCase));
        if (prefixed is null)
            return false;

        if (prefixed == raw)
            return Parse.Try<U>(Common.Base, out match);

        var extra = raw[..^prefixed.Length]; // == raw.Substring(0, raw.Length - prefixed.Length)
        return Parse.Try<U>(extra, out match);
    }

    private static readonly string[] _baseNames = [
        .. Si.Base.NameAbbr.Keys.ToArray(),
        .. Si.Derived.Base.NameAbbr.Keys.ToArray(),
        .. Si.Accepted.Base.NameAbbr.Keys.ToArray()];
}