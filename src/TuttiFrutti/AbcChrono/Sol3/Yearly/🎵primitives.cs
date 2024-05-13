namespace AbcChrono.Sol3.Yearly;
public interface IAnnual
{
    string Year(ulong val);
}

public interface IYearX100
{
    string Century(ushort val);
}

public interface IYearX1_000
{
    string Millennium(uint val);
}

public interface IYearX10_000
{
    string Decamillenniuum(ushort val);
}

public interface IYearX100_000
{
    string Centamillenniuum(ushort val);
}

public interface IYearX1_000_000
{
    string Megaannum(ushort val);
}


public interface IYearX1_000_000_000
{
    string Billion(uint val);
}
