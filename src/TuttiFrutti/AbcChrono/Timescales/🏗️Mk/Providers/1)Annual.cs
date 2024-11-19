using AbcChrono.Timescales.Sol3.Mk.Blocks;
using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Mk.Providers;
class Annual(IHap model) : YearsX1(model), IYearX1WithCurrent
{
    public IHap ThisYear() => Year((ulong)DateTime.Now.Year);
}
