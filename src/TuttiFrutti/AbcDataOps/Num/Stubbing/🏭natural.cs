namespace AbcDataOps.Num.Stubbing;
public partial class PolyStub
{
    public static PolyStub<byte> Of(byte value) => new(value) {
        IsPow2 = () => byte.IsPow2(value)
    };

    public static PolyStub<ushort> Of(ushort value) => new(value) {
        IsPow2 = () => ushort.IsPow2(value)
    };

    public static PolyStub<uint> Of(uint value) => new(value) {
        IsPow2 = () => uint.IsPow2(value)
    };

    public static PolyStub<ulong> Of(ulong value) => new(value) {
        IsPow2 = () => ulong.IsPow2(value)
    };
}
