using AbcChrono.Sol3.Era;

namespace AbcChrono.Mk.Providers;
class YearCentiEra<Anni>(On scale) : Full<Anni>(scale), IModern<Anni>
    where Anni : IAnnual
{
    new public IYearCenti_wShortcuts circa() => (IYearCenti_wShortcuts)base.circa();
    new public IYearCenti_wShortcuts circa(ushort delta = 1) => (IYearCenti_wShortcuts)base.circa(delta);
}

class YearCentiMilleEra<Anni>(On scale) : Full<Anni>(scale), ILong<Anni>
    where Anni : IAnnual
{
    new public IYearCentiMille circa() => (IYearCentiMille)base.circa();
    new public IYearCentiMille circa(ushort delta = 1) => (IYearCentiMille)base.circa(delta);
}
