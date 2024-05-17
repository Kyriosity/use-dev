namespace AbcChrono.Sol3.Yearly;
public interface IAnnual { IEvent Year(ulong val); }

public interface IYearX100 { IEvent Century(ushort val); }

public interface IYearX1_000 { IEvent Millennium(uint val); }

public interface IYearX10_000 { IEvent Decamillenniuum(ushort val); }

public interface IYearX100_000 { IEvent Centamillenniuum(ushort val); }

public interface IYearX1_000_000 { IEvent Megaannum(ushort val); }

public interface IYearX1_000_000_000 { IEvent Billion(uint val); }
