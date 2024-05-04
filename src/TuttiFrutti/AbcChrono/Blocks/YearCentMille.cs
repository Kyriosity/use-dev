namespace AbcChrono.Blocks;
public class YearCentMille(string model) : YearCent(model)
{
    public string Millenium(ushort val) {
        Model = $"Millenium {val}";
        return Model;
    }
}
