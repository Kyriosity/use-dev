namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Fruit<TSrc>(TSrc seed) : Fruit<TSrc, bool>(seed);
public abstract class Fn_Fruit<TSrc, Fn>(TSrc seed) : Fn_Fruit<TSrc, bool, Fn>(seed)
    where Fn : fuseFn.IBool;
public abstract class Fruit_Fn<TSrc, Fn>(TSrc seed) : Fruit_Fn<TSrc, bool, Fn>(seed)
    where Fn : fuseFn.IBool;
public abstract class Fn_Fruit_Fn<TSrc, FnLeft, FnRight>(TSrc seed) : Fn_Fruit_Fn<TSrc, bool, FnLeft, FnRight>(seed)
    where FnLeft : fuseFn.IBool
    where FnRight : fuseFn.IBool;


