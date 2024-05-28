using AbcExt.Chrono.Scale;

namespace AbcExt.Chrono.Convert;
public class To
{
    public static IYears<ulong> Abs = Year<ulong>(On.Universe);
    public static IYears<NRes> Year<NRes>(On epoch) where NRes : INumber<NRes>
        => new Full<NRes> { Target = epoch };
}