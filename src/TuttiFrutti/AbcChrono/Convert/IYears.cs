using AbcChrono.Timescales;

namespace AbcChrono.Convert;
public interface IYears<NRes> where NRes : INumber<NRes>
{
    NRes From<N>(On source, N val, Units.Annual.In unit) where N : INumber<N>;
}
