
using Abc.Ext.Xlat;
using Si = Meas.Units.Names.Si;

namespace Meas.Units;
public static class Metric
{
    public static bool TryLooseMatch<U>(string raw, out U? match) where U : Enum {
        if (Parse.Try<U>(raw, out match))
            return true;

        var prefixed = _baseNames.SingleOrDefault(baseName => raw.EndsWith(baseName, StringComparison.InvariantCultureIgnoreCase));
        if (prefixed is null)
            return false;

        if (prefixed == raw)
            return Parse.Try<U>("base", out match);

        var extra = raw.Substring(0, raw.Length - prefixed.Length);
        return Parse.Try<U>(extra, out match);
    }

    private static readonly string[] _baseNames = [.. Si.Base.NameAbbr.Keys.ToArray(), .. Si.Derived.Base.NameAbbr.Keys.ToArray(), .. Si.Accepted.Base.NameAbbr.Keys.ToArray()];
}