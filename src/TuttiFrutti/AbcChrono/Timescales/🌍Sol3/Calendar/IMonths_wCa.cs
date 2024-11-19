using AbcChrono.Timescales.Sol3.Yearly;

namespace AbcChrono.Timescales.Sol3.Calendar;
public interface IMonths_wCa<Anni> : IMonths<Anni>, IApproximate<IMonths<Anni>, short>
    where Anni : IAnnual;
