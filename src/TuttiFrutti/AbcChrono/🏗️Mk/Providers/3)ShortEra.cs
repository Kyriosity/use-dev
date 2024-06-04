using AbcChrono.Sol3.Era;

namespace AbcChrono.Mk.Providers;
class ShortEra(On scale) : Full<IYearX1>(scale), IEpochRuler
{
    public IYearX1 circa() => base.circa();
    public IYearX1 circa(byte delta) => base.circa(delta);

}
