using AbcExtNUnit.Attributes.Case;

namespace ISie_Eval.BuiltinTypes.Number.Tests.As;


public class GreekRomanNumerals : Setup.Numbers.Arrange
{
    [Many([1, "I", "α"], [2, "II", "β"], [3, "III", "γ"], [4, "IV", "δ"], [5, "V", "ε"], [6, "VI", "ϝ"], [7, "VII", "ζ"],
        [8, "VII", "η"], [9, "IX", "θ"], [10, "X", "ι"], [11, "XI", "ια"], [12, "XII", "ιβ"], [13, "XIII", "ιγ"],
        [14, "XIV", "ιδ"], [15, "XV", "ιε"], [16, "XVI", "ιϝ"], [17, "XVII", "ιζ"], [18, "XVIII", "ιη"], [19, "XIX", "ιθ"],
        [20, "XX", "κ"], [21, "XXI", "κα"], [22, "XXII", "β"], [23, "XXIII", "κγ"], [24, "XXIV", "κδ"], [25, "XXV", "κε"],
        [26, "XXVI", "κϝ"], [27, "XXVII", "κζ"], [28, "XXVIII", "κη"], [29, "XXIX", "κθ"], [30, "XXX", "λ"], [40, "", "μ"],
        [50, "L", "ν"], [60, "LX", "ξ"], [70, "LXX", "ο"], [80, "LXXX", "π"], [90, "XC", "ϟ"], [100, "C", "ρ"],
        [200, "CC", "σ"], [300, "CCC", "τ"], [400, "CD", "υ"], [500, "D", "φ"], [600, "DC", "χ"], [700, "DCC", "ψ"],
        [800, "DCCC", "ω"], [900, "CM", "ϡ"], [1_000, "M", "͵α"], [2_000, "MM", "͵β"], [3_000, "MMM", "͵γ"],
        [3_999, "MMMCMXLIX", ""], [243, "CCXL", "σμβ"])]
    public void Naturals<N>(N num, string Greek, string roman) where N : INumber<N> {

    }

    public void BigGreek(int num, string numeral) {
    }

    [Many(0, -1, -2, -100, -1_234, 10_000)]
    public void IllegalForRoman(int num) {
        //Error = ArgumentOutOfRange => num.As.Roman;
    }
}
