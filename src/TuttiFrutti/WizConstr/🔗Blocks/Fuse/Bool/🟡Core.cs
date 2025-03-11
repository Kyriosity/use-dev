namespace WizConstr.Blocks.Fuse.Bool;

public abstract class Core<TSrc>(TSrc seed) : _core<TSrc, bool>(seed);

public abstract class Core_Fn<TSrc, TFn>(TSrc seed) : Core_Fn<TSrc, bool, TFn>(seed) where TFn : fuseFn.IBool;


public abstract class Core_Or<TSrc>(TSrc seed) : Core_Fn<TSrc, fuseFn.IDisjunct>(seed);

public abstract class Core_And<TSrc>(TSrc seed) : Core_Fn<TSrc, fuseFn.IConjunct>(seed);

public abstract class Core_Xor<TSrc>(TSrc seed) : Core_Fn<TSrc, fuseFn.IExclude>(seed);