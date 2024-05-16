using AbcChrono.Sol3.Era;

namespace AbcChrono.Mk.Providers;
class YearCentiEra : Full, IModern
{
    new public IMonths_wShortcuts_wCa At => At;

    new public IYearCenti_wShortcuts circa() => (IYearCenti_wShortcuts)base.circa();
    new public IYearCenti_wShortcuts circa(ushort delta = 1) => (IYearCenti_wShortcuts)base.circa(delta);
}

class YearCentiMilleEra : Full, ILong
{
    new public IYearCentiMille circa() => (IYearCentiMille)base.circa();
    new public IYearCentiMille circa(ushort delta = 1) => (IYearCentiMille)base.circa(delta);
}
