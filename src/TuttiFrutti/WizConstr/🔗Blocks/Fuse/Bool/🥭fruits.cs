namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Fruit<TSrc>(TSrc seed) : Core<TSrc>(seed)
{
    public static implicit operator bool(Fruit<TSrc> source) => source.Yield();
}

public abstract class Lnk_Fruit<TSrc, Lnk>(TSrc seed) : Lnk_Core<TSrc, Lnk>(seed)
    where Lnk : fuseFn.IBool
{
    public static implicit operator bool(Lnk_Fruit<TSrc, Lnk> source) => source.Yield();
}

public abstract class Fruit_Lnk<TSrc, Lnk>(TSrc seed) : Core_Lnk<TSrc, Lnk>(seed)
    where Lnk : fuseFn.IBool
{
    public static implicit operator bool(Fruit_Lnk<TSrc, Lnk> source) => source.Yield();
}

public abstract class Lnk_Fruit_Lnk<TSrc, LnkLeft, LnkRight>(TSrc seed) : Lnk_Core_Lnk<TSrc, LnkLeft, LnkRight>(seed)
    where LnkLeft : fuseFn.IBool
    where LnkRight : fuseFn.IBool
{
    public static implicit operator bool(Lnk_Fruit_Lnk<TSrc, LnkLeft, LnkRight> source) => source.Yield();

}
