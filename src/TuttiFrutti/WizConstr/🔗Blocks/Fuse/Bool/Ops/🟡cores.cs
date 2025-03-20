namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Core_Or<TSrc> : Core_Lnk<TSrc, fuseFn.IDisjunct>;

public abstract class Core_And<TSrc> : Core_Lnk<TSrc, fuseFn.IConjunct>;

public abstract class Core_Xor<TSrc> : Core_Lnk<TSrc, fuseFn.IExclude>;

public abstract class Or_Core<TSrc> : Lnk_Core<TSrc, fuseFn.IDisjunct>;

public abstract class And_Core<TSrc> : Lnk_Core<TSrc, fuseFn.IConjunct>;

public abstract class Xor_Core<TSrc> : Lnk_Core<TSrc, fuseFn.IExclude>;
