namespace AbcDataOps.Num.Stubbing;
public partial class PolyStub
{
    public static PolyStub<sbyte> Of(sbyte value) => new(value) {
        IsPow2 = () => sbyte.IsPow2(value)
    };

    public static PolyStub<short> Of(short value) => new(value) {
        IsPow2 = () => short.IsPow2(value)
    };

    public static PolyStub<int> Of(int value) => new(value) {
        IsPow2 = () => int.IsPow2(value)
    };

    public static PolyStub<long> Of(long value) => new(value) {
        IsPow2 = () => long.IsPow2(value)
    };
}