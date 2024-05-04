namespace AbcChrono.Blocks;
public class YearCentMilleMegaGiga(string model) : YearCentMilleMega(model)
{
    public string Aeon(byte val) {
        Model = $"Aeon {val}";
        return Model;
    }
}
