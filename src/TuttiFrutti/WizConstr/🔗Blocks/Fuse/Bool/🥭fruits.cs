namespace WizConstr.Blocks.Fuse.Bool;

public class Fruit<T> : Pulp<T>
{
    public static implicit operator bool(Fruit<T> source) => source.Yield();
}

public class Lnk_Fruit<T, Lnk> : Lnk_Pulp<T, Lnk>
    where Lnk : fuseFn.IBool
{
    public static implicit operator bool(Lnk_Fruit<T, Lnk> source) => source.Yield();
}

public class Fruit_Lnk<T, Lnk> : Pulp_Lnk<T, Lnk>
    where Lnk : fuseFn.IBool
{
    public static implicit operator bool(Fruit_Lnk<T, Lnk> source) => source.Yield();
}

public class Lnk_Fruit_Lnk<T, LnkLeft, LnkRight> : Lnk_Pulp_Lnk<T, LnkLeft, LnkRight>
    where LnkLeft : fuseFn.IBool
    where LnkRight : fuseFn.IBool
{
    public static implicit operator bool(Lnk_Fruit_Lnk<T, LnkLeft, LnkRight> source) => source.Yield();

}
