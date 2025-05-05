using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Pulp_Or<T> : Pulp_Lnk<T, IDisjunct>;

public abstract class Pulp_And<T> : Pulp_Lnk<T, IConjunct>;


public abstract class Or_Pulp<T> : Lnk_Pulp<T, IDisjunct>;

public abstract class And_Pulp<T> : Lnk_Pulp<T, IConjunct>;

// EXCLUDE can't be shortcut and thus requires other than lazy realization ON DEMAND
//public abstract class Pulp_Xor<T> : Pulp_Lnk<T, IExclude>;
//public abstract class Xor_Pulp<T> : Lnk_Pulp<T, IExclude>;