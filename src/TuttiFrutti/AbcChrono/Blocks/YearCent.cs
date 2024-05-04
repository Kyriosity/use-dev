using AbcChrono.Blocks.Bits;

namespace AbcChrono.Blocks;
public class YearCent : Yearly
{
    public YearCent(string model) : base(model) {
    }

    public string Century(ushort val) {
        Model = $"Century {val}";
        return Model;
    }
}
