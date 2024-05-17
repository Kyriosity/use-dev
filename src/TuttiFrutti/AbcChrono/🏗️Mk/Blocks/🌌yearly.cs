namespace AbcChrono.Sol3.Mk.Blocks;
abstract class YearsX1(IEvent model) : Basal(model), IAnnual
{
    public IEvent Year(ulong val) {
        // ToProp:  = $" > Year {val}";
        return Model;
    }
}

abstract class YearsX100(IEvent model) : YearsX1(model), IYearX100
{
    public IEvent Century(ushort val) {
        // ToProp: Model = $"Century {val}";
        return Model;
    }
}

abstract class YearsX1_000(IEvent model) : YearsX100(model), IYearX1_000
{
    public IEvent Millennium(uint val) {
        // ToProp: Model = $"Millenium {val}";
        return Model;
    }
}

abstract class YearsX10_000(IEvent model) : YearsX1_000(model), IYearX10_000
{
    public IEvent Decamillenniuum(ushort val) {
        // ToProp: Model = $"Decem-Millenium {val}";
        return Model;
    }
}

abstract class YearsX100_000(IEvent model) : YearsX10_000(model), IYearX100_000
{
    public IEvent Centamillenniuum(ushort val) {
        // ToProp: Model = $"Millenium {val}";
        return Model;
    }
}

abstract class YearsX1_000_000(IEvent model) : YearsX100_000(model), IYearX1_000_000
{
    public IEvent Megaannum(ushort val) {
        // ToProp: Model = $"Megaannum {val}";
        return Model;
    }
}

abstract class YearsX1_000_000_000(IEvent model) : YearsX1_000_000(model), IYearX1_000_000_000
{
    public IEvent Billion(uint val) {
        // ToProp: Model = $"Billion {val}";
        return Model;
    }
}



