using AbcExt.Chrono.Scale;

namespace AbcExt.Chrono.Convert;
public interface IYears<NRes> where NRes : INumber<NRes>
{
    NRes From<N>(On source, N val, Units.Annual.In unit) where N : INumber<N>;
}
