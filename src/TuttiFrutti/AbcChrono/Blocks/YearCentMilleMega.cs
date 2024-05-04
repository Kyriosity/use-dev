namespace AbcChrono.Blocks;
public class YearCentMilleMega(string model) : YearCentMille(model)
{
    public string Megaannum(ushort val) {
        Model = $"MILLION {val}";
        return Model;
    }
}
