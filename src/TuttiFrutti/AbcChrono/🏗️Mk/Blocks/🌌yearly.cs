namespace AbcChrono.Sol3.Mk.Blocks;
abstract class YearsX1(IHap model) : Basal(model), IYearX1
{
    public IHap Year(ulong val) {
        if (Month.February == Model.MonthName && Model.DayNr is not null
            && On.CommonEra == Model.Epoch && val % 4 is not 0) // INFO: this is a simplified proc of leap year w/ partial coverage
            ArgumentOutOfRangeException.ThrowIfGreaterThan((int)Model.DayNr, 28, $"leap year {val}");

        if (Model.Epoch is On.CommonEra or On.BeforeCommonEra)
            ArgumentOutOfRangeException.ThrowIfZero(val, $"Invalid zero year for {Model.Epoch}");

        return Model.Set(val, In.Year);
    }
}

abstract class YearsX100(IHap model) : YearsX1(model), IYearX100
{
    public IHap Century(ushort val) => Model.Set(val, In.Century);
}

abstract class YearsX1_000(IHap model) : YearsX100(model), IYearX1_000
{
    public IHap Millennium(uint val) => Model.Set(val, In.Millennium);
}

abstract class YearsX10_000(IHap model) : YearsX1_000(model), IYearX10_000
{
    public IHap Decamillenniuum(ushort val) => Model.Set(val, In.Decamillennium);
}

abstract class YearsX100_000(IHap model) : YearsX10_000(model), IYearX100_000
{
    public IHap Centamillenniuum(ushort val) => Model.Set(val, In.Centamillennial);
}

abstract class YearsX1_000_000(IHap model) : YearsX100_000(model), IYearX1_000_000
{
    public IHap Megaannum(ushort val) => Model.Set(val, In.Megaannum);
}

abstract class YearsX1_000_000_000(IHap model) : YearsX1_000_000(model), IYearX1_000_000_000
{
    public IHap Billion(uint val) => Model.Set(val, In.Billion);
}



