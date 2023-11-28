using System.Diagnostics.CodeAnalysis;

namespace Meas.Units;
public static class MetricUnits
{
    public static readonly string[][] Labels = {
        [ "micro", ],
        [ "milli", "10-3", "milligramm" ],
        [ "BASE", "second", "s", "meter", "metre", "m", "gramm", "g", "ampere", "A", "kelvin", "K", "mole", "mol", "candela", "cd" ]
    };

    public static bool TryLooseMatch<U>(string raw, out U? match) where U : Enum {
        if (Parse.Try<U>(raw, out match))
            return true;

        //if (raw in SiBase OR siDerivedBase)
        //    return Parse.Try<U>(raw, out match);

        //if (Enum.TryParse(typeof(U), variants[0], no_case, out object? res)) {
        //    match = (U)res;
        //}
        //else if (true) {
        //    if (Enum.TryParse(typeof(U), "base", no_case, out object? res))
        //}

        //
        // IF IN SI BASE

        // IN IN SI DERIVED

        // EXCLUDE 


        return false;
    }
}

public static class Parse
{
    public static bool Try<U>(string rawMember, [NotNullWhen(true)] out U? match) where U : Enum {
        const bool case_insensitive = false;

        var success = Enum.TryParse(typeof(U), rawMember, case_insensitive, out object? parsed);
        match = success ? (U?)parsed : default;
        return success;
    }
}

