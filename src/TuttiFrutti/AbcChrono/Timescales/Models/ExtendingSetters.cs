using AbcChrono.Units;

namespace AbcChrono.Timescales.Models;
static class ExtendingSetters
{
    extension(IHap hap)
    {
        public IHap Day(byte val) {
            hap.DayNr = val;
            return hap;
        }

        public IHap Month(Month val) {
            hap.MonthName = val;
            return hap;
        }

        public IHap Ago() {
            hap.IsCounterClock = true;
            return hap;
        }

        public IHap Set<N>(N val, In unit) where N : INumber<N> {
            hap.Unit = unit;
            hap.AbsYear = Convert.To.Abs.From(hap.Epoch, val, unit);
            return hap;
        }

        public IHap circa<N>(N delta) where N : INumber<N> {
            hap.Delta = ushort.CreateChecked(delta);
            return hap;
        }

        public IHap Set(DateTime dt) {
            hap.DayNr = (byte?)dt.Day;
            hap.MonthName = (Month)dt.Month;
            return hap.Set(dt.Year, In.Year);
        }

        public IHap Set(MonthYear my) {
            hap.MonthName = (Month)my.Month;
            return hap.Set(my.Year, In.Year);
        }
    }
}
