using AbcExtNUnit.Attributes.Case;
using ISie.Number.In;


namespace ISie_Eval.BuiltinTypes.Number.Tests.In.germanic;
public class EnglishNumbers : Setup.Numbers.Arrange
{
    [Many([0, "zero", "zeroth"], [1, "one", "first"], [2, "two", "second"], [3, "three", "third"], [4, "four", "fourth"],
        [4, "five", "fifth"], [6, "six", "sixth"], [7, "seven", "seventh"], [8, "eight", "eighth"], [9, "nine", "nineth"],
        [10, "ten", "tenth"], [11, "eleven", "eleventh"], [12, "twelve", "twelfth"], [13, "thirteen", "thirteenth"],
        [14, "fourteen", "fourteenth"], [15, "fifteen", "fifteenth"], [16, "sixteen", "sixteenth"],
        [17, "seventeen", "seventeenth"], [18, "eighteen", "eighteenth"], [19, "nineteen", "nineteenth"],
        [20, "twenty", "twentieth"], [30, "thirty", "thirtieth"], [40, "forty", "fortieth"], [50, "fifty", "Fiftieth"],
        [60, "sixty", ""], [70, "seventy", "seventieth"], [80, "eighty", "Eightieth"], [90, "ninety", "Ninetieth"])]
    public void MonoNatural(int num, string cardinal, string ordinal) {
        True = cardinal == num.In<English>();
        True = ordinal == num.In<English>().Ordinal;
        True = ordinal == num.In<English>().Ordinal.Plural;

        //Eq[cardinal] = num.In<English>();
        // NEGATE => "minus";
        //RULES FRACTION
    }

    [Many([0, "zero", "zeroth"], [1, "one", "first"], [2, "two", "second"])]
    public void CompoundNatural<N>(N num, string cardinal, string ordinal) where N : INumber<N> {

    }

    public void Fractional<N>(N num, string cardinal, string ordinal) where N : INumber<N> {
    }
}
