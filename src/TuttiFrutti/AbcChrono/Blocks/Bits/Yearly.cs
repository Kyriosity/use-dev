namespace AbcChrono.Blocks.Bits;
public class Yearly : Basal
{
    public Yearly(string model) : base(model) {

    }

    public string Year(ulong val) {
        Model = $" > Year {val}";
        return Model;
    }
}

