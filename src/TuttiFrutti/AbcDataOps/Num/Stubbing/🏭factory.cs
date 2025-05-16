namespace AbcDataOps.Num.Stubbing;
public class PolyStub
{
    public static PolyStub<byte> Of(byte value) => new(value) {
        IsPow2 = () => byte.IsPow2(value)
    };

    public static PolyStub<sbyte> Of(sbyte value) => new(value) {
        // MUST THROW  IsPow2 = () => byte.IsPow2(value)
    };

    public static PolyStub<int> Of(int value) => new(value) {
        IsPow2 = () => int.IsPow2(value)
    };

    public static PolyStub<double> Of(double value) => new(value) {
        IsPow2 = () => double.IsPow2(value)
    };
}
