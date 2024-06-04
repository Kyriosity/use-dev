namespace AbcChrono.Sol3.Yearly;
public interface IYearCenti : IYearX1, IYearX100;
public interface IYearCentiMille : IYearX1, IYearX100, IYearX1_000;

public interface IMilleMegaGiga : IYearX1_000_000, IYearX1_000_000_000;

public interface ICentiMilleDecamille : IYearX100, IYearX1_000, IYearX10_000;

public interface IMilleTenThousandsPlus : IYearX1_000, IYearX10_000, IYearX100_000, IYearX1_000_000;
public interface IMilleCentiThousandsUnlim : IYearX1_000, IYearX100_000, IYearX1_000_000, IYearX1_000_000_000;

public interface IYearX1WithCurrent : IYearX1, IYearCurrent;
