namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Pulp_Or<T> : Pulp_Lnk<T, fuseFn.IDisjunct>;

public abstract class Pulp_And<T> : Pulp_Lnk<T, fuseFn.IConjunct>;

public abstract class Pulp_Xor<T> : Pulp_Lnk<T, fuseFn.IExclude>;

public abstract class Or_Pulp<T> : Lnk_Pulp<T, fuseFn.IDisjunct>;

public abstract class And_Pulp<T> : Lnk_Pulp<T, fuseFn.IConjunct>;

public abstract class Xor_Pulp<T> : Lnk_Pulp<T, fuseFn.IExclude>;