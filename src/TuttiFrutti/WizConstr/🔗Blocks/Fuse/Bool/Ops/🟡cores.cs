namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Core_Or<TSrc>(TSrc seed) : Core_Fn<TSrc, fuseFn.IDisjunct>(seed);

public abstract class Core_And<TSrc>(TSrc seed) : Core_Fn<TSrc, fuseFn.IConjunct>(seed);

public abstract class Core_Xor<TSrc>(TSrc seed) : Core_Fn<TSrc, fuseFn.IExclude>(seed);

public abstract class Or_Core<TSrc>(TSrc seed) : Fn_Core<TSrc, fuseFn.IDisjunct>(seed);

public abstract class And_Core<TSrc>(TSrc seed) : Fn_Core<TSrc, fuseFn.IConjunct>(seed);

public abstract class Xor_Core<TSrc>(TSrc seed) : Fn_Core<TSrc, fuseFn.IExclude>(seed);
