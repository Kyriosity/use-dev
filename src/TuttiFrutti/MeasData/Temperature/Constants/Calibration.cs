using MeasData.Setup.Metadata;

namespace MeasData.Temperature.Constants;
public partial class Constants
{
    public const string AbsZero = "Absolute zero";
    public const string AbsoluteZero = "Absolute zero";

    [Precision(1.0)]
    Rec Extremes = [
        (long.MinValue, Fahrenheit, "=@max", (long)-5_124_095_576_030_431_232, Celsius),
        (long.MinValue, Fahrenheit, "=@max", (long)-5_124_095_576_030_431_232, Celsius),

        (uint.MaxValue, Fahrenheit, "=@max", (uint)2_386_092_924, Celsius),
        (int.MaxValue, F, "=@max", (int)1_193_046_453, C),
        (int.MinValue, F, "=@max", (int)-1_193_046_488, C),

        (short.MaxValue, Fahrenheit, "=@max", (short)18_186, C),

        (byte.MaxValue, F, "=@max", (byte)124, C),

        (sbyte.MaxValue, F, "=@max", (sbyte)53, C),
        (sbyte.MinValue, F, "=@max", (sbyte)-89, C),
    ];

    [Precision(.000_001)]
    Dir ControlPoints = new() {
        ["0 Celcius"] = [(0, Celsius), (273.15, Kelvin), (32, F)],
        ["0 Fahrenheit"] = [(0, Fahrenheit), (-17.777_777_777_777_778, Celsius), (255.372_222_222_222_222, Kelvin)], // ToDebug: test fail!
        ["C-F intersect"] = [(-40, C), (-40, F)],
    };
}
