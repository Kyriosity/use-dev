using AbcLingua.Tongues;
using System.Numerics;

namespace AbcLingua.Numbers;
public class Words<T> where T : IScript, ISupported
{
    /// NOTE: This is a placeholder for demos.
    /// ToBe: developed on demand

    public static string Cardinal<N>(N value) where N : INumber<N> {
        if (N.Zero == value) return "zero";


        return $"{{{value}}}";
    }

    public static string Ordinal<N>(N value) where N : INumber<N> {
        if (N.Zero == value) return "zero";
        if (N.One == value) return "first";

        return $"{{{value}}}";
    }

    //static bool Mono<N>(N num, out string res) where N : INumber<N> {

    //    res = num switch {
    //        0 => string.Empty,
    //        1 => "one",
    //        2 => "two",
    //        3 => "three",
    //        4 => "four",
    //        5 => "five",
    //        6 => "six",
    //        7 => "seven",
    //        8 => "eight",
    //        9 => "nine",
    //        10 => "ten",
    //        11 => "eleven",

    //    };
    //}
}
