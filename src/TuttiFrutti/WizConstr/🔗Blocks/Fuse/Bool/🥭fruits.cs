namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Fruit<TSrc>(TSrc seed) : Core<TSrc>(seed)
{
    public static implicit operator bool(Fruit<TSrc> source) => source.Yield();
}

public abstract class Fn_Fruit<TSrc, Fn>(TSrc seed) : Fn_Core<TSrc, Fn>(seed)
    where Fn : fuseFn.IBool
{
    public static implicit operator bool(Fn_Fruit<TSrc, Fn> source) => source.Yield();

}

public abstract class Fruit_Fn<TSrc, Fn>(TSrc seed) : Core_Fn<TSrc, Fn>(seed)
    where Fn : fuseFn.IBool
{
    public static implicit operator bool(Fruit_Fn<TSrc, Fn> source) => source.Yield();
}

public abstract class Fn_Fruit_Fn<TSrc, FnLeft, FnRight>(TSrc seed) : Fn_Core_Fn<TSrc, FnLeft, FnRight>(seed)
    where FnLeft : fuseFn.IBool
    where FnRight : fuseFn.IBool
{
    public static implicit operator bool(Fn_Fruit_Fn<TSrc, FnLeft, FnRight> source) => source.Yield();

}
