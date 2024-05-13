namespace AbcChrono.Sol3.Mk.Blocks;
abstract class YearsX1(string model) : Basal(model), IAnnual
{
    public string Year(ulong val) {
        Model = $" > Year {val}";
        return Model;
    }
}

abstract class YearsX100(string model) : YearsX1(model), IYearX100
{
    public string Century(ushort val) {
        Model = $"Century {val}";
        return Model;
    }
}

abstract class YearsX1_000(string model) : YearsX100(model), IYearX1_000
{
    public string Millennium(uint val) {
        Model = $"Millenium {val}";
        return Model;
    }
}

abstract class YearsX10_000(string model) : YearsX1_000(model), IYearX10_000
{
    public string Decamillenniuum(ushort val) {
        Model = $"Decem-Millenium {val}";
        return Model;
    }
}

abstract class YearsX100_000(string model) : YearsX10_000(model), IYearX100_000
{
    public string Centamillenniuum(ushort val) {
        Model = $"Millenium {val}";
        return Model;
    }
}

abstract class YearsX1_000_000(string model) : YearsX100_000(model), IYearX1_000_000
{
    public string Megaannum(ushort val) {
        Model = $"Megaannum {val}";
        return Model;
    }
}

abstract class YearsX1_000_000_000(string model) : YearsX1_000_000(model), IYearX1_000_000_000
{
    public string Billion(uint val) {
        Model = $"Billion {val}";
        return Model;
    }
}



