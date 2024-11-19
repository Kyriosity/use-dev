namespace AbcChrono.Timescales.Sol3.Yearly;

public interface IAnnual;
public interface IYearX1 : IAnnual { IHap Year(ulong val); }

public interface IYearCurrent : IAnnual { IHap ThisYear(); }

public interface IYearX100 { IHap Century(ushort val); }

public interface IYearX1_000 { IHap Millennium(uint val); }

public interface IYearX10_000 { IHap Decamillenniuum(ushort val); }

public interface IYearX100_000 { IHap Centamillenniuum(ushort val); }

public interface IYearX1_000_000 { IHap Megaannum(ushort val); }

public interface IYearX1_000_000_000 { IHap Billion(uint val); }

