namespace AbcDataOps.Num.Stubbing;
public partial class PolyStub
{
    public static PolyStub<double> Of(double value) => new(value) {
        IsPow2 = () => double.IsPow2(value)
    };
}
