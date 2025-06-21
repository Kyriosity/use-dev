namespace WizConstr.Blocks;
public class Fruit<T, TRes> : Pulp<T, TRes>
{
    public static implicit operator TRes(Fruit<T, TRes> source) => source.Yield();
}
