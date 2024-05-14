using AbcChrono.Sol3.Era;

namespace AbcChrono.Mk.Providers;
class YearCentiEra : Full, IModern
{
    new public IMonths_wShortcuts_wCa At => At;

    new public IYearCenti circa() => (IYearCenti)base.circa();
    new public IYearCenti circa(ushort delta = 1) => (IYearCenti)base.circa(delta);
}

class YearCentiMilleEra : Full, ILong
{
    new public IMonths_wCa<IMonths> At => At;

    new public IYearCentiMille circa() => (IYearCentiMille)base.circa();
    new public IYearCentiMille circa(ushort delta = 1) => (IYearCentiMille)base.circa(delta);
}
