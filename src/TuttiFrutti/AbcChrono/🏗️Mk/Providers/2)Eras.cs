using AbcChrono.Sol3.Era;

namespace AbcChrono.Mk.Providers;
class YearCentiEra(Scale scale) : Full(scale), IModern
{
    new public IYearCenti_wShortcuts circa() => (IYearCenti_wShortcuts)base.circa();
    new public IYearCenti_wShortcuts circa(ushort delta = 1) => (IYearCenti_wShortcuts)base.circa(delta);
}

class YearCentiMilleEra(Scale scale) : Full(scale), ILong
{
    new public IYearCentiMille circa() => (IYearCentiMille)base.circa();
    new public IYearCentiMille circa(ushort delta = 1) => (IYearCentiMille)base.circa(delta);
}
