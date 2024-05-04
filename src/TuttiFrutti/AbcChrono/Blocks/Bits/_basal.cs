namespace AbcChrono.Blocks.Bits;
public class Basal
{
    public Basal(string model) {
        Model = model;
    }


    protected string Model { get => _model; set { _model += " > " + value; } }
    private string _model = "Event";

}
