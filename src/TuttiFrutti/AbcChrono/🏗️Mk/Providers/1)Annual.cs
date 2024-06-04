using AbcChrono.Sol3.Mk.Blocks;

namespace AbcChrono.Mk.Providers;
class Annual(IHap model) : YearsX1(model), IAnnualCurrent
{
    public IHap ThisYear() => Year((ulong)DateTime.Now.Year);
}
