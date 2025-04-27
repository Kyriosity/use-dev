namespace WizConstr.Blocks.Fuse;

public class Pulp<T, TRes> : basal.rightVoid<T, TRes>, INoLnkLeft;

public class Fruit<T, TRes> : Pulp<T, TRes>
{
    public static implicit operator TRes(Fruit<T, TRes> source) => source.Yield();
}