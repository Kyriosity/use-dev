namespace AbcDataOps.Num.Stubbing;
public partial class PolyStub
{
    public static PolyStub<double> Of(double value) => new(value) {
        IsPow2 = () => double.IsPow2(value)
    };
    public static PolyStub<float> Of(float value) => new(value) {
        IsPow2 = () => float.IsPow2(value)
    };
    public static PolyStub<decimal> Of(decimal value) => new(value) {
        IsPow2 = () => decimal.IsInteger(value) && double.IsPow2((double)value)
    };
}