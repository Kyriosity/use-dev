namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Fruit<TSrc> : Core<TSrc>
{
    public static implicit operator bool(Fruit<TSrc> source) => source.Yield();
}

public abstract class Lnk_Fruit<TSrc, Lnk> : Lnk_Core<TSrc, Lnk>
    where Lnk : fuseFn.IBool
{
    public static implicit operator bool(Lnk_Fruit<TSrc, Lnk> source) => source.Yield();
}

public abstract class Fruit_Lnk<TSrc, Lnk> : Core_Lnk<TSrc, Lnk>
    where Lnk : fuseFn.IBool
{
    public static implicit operator bool(Fruit_Lnk<TSrc, Lnk> source) => source.Yield();
}

public abstract class Lnk_Fruit_Lnk<TSrc, LnkLeft, LnkRight> : Lnk_Core_Lnk<TSrc, LnkLeft, LnkRight>
    where LnkLeft : fuseFn.IBool
    where LnkRight : fuseFn.IBool
{
    public static implicit operator bool(Lnk_Fruit_Lnk<TSrc, LnkLeft, LnkRight> source) => source.Yield();

}
