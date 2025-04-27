namespace WizConstr.Blocks.Fuse.Bool.Ops.Ripe.End;

public class Or_Fruit<T> : Ops.Or_Fruit<T>
{
    public Or_Fruit(Func<T, bool> xform) {
        XForm = xform;
    }
    // ToDesign: COMMON xform()
}

public class And_Fruit<T> : Ops.And_Fruit<T>
{
    public And_Fruit(Func<T, bool> xform) {
        XForm = xform;
    }
}

public class Xor_Fruit<T> : Ops.Xor_Fruit<T>
{
    public Xor_Fruit(Func<T, bool> xform) {
        XForm = xform;
    }
}