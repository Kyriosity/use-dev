using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse.Bool.Ops;

public abstract class Fruit_Or<T> : Fruit_Lnk<T, IDisjunct>;
public abstract class Fruit_And<T> : Fruit_Lnk<T, IConjunct>;
//public abstract class Fruit_Xor<T> : Fruit_Lnk<T, IExclude>;