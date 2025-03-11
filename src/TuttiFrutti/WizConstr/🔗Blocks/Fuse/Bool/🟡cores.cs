namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Core<TSrc>(TSrc seed) : Core<TSrc, bool>(seed);

public abstract class Core_Fn<TSrc, Fn>(TSrc seed) : Core_Fn<TSrc, bool, Fn>(seed) where Fn : fuseFn.IBool;

public abstract class Fn_Core<TSrc, Fn>(TSrc seed) : Fn_Core<TSrc, bool, Fn>(seed) where Fn : fuseFn.IBool;

public abstract class Fn_Core_Fn<TSrc, FnLeft, FnRight>(TSrc seed) : Fn_Core_Fn<TSrc, bool, FnLeft, FnRight>(seed)
    where FnLeft : fuseFn.IBool
    where FnRight : fuseFn.IBool;
