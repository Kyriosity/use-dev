namespace AbcChrono.Sol3.Calendar;
public interface IMonths_wCa<Anni> : IMonths<Anni>, IApproximate<IMonths<Anni>, short>
    where Anni : IAnnual;
