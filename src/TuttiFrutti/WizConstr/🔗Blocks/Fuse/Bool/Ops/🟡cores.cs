namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Pulp_Or<TSrc> : Pulp_Lnk<TSrc, fuseFn.IDisjunct>;

public abstract class Pulp_And<TSrc> : Pulp_Lnk<TSrc, fuseFn.IConjunct>;

public abstract class Pulp_Xor<TSrc> : Pulp_Lnk<TSrc, fuseFn.IExclude>;

public abstract class Or_Pulp<TSrc> : Lnk_Pulp<TSrc, fuseFn.IDisjunct>;

public abstract class And_Pulp<TSrc> : Lnk_Pulp<TSrc, fuseFn.IConjunct>;

public abstract class Xor_Pulp<TSrc> : Lnk_Pulp<TSrc, fuseFn.IExclude>;
