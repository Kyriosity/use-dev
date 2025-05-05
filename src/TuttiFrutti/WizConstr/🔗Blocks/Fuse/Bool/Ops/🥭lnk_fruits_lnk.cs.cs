using Abc.Logic.Fuse.Lazy;

namespace WizConstr.Blocks.Fuse.Bool.Ops;
public abstract class Or_Fruit_Or<T> : Lnk_Fruit_Lnk<T, IDisjunct, IDisjunct>;
public abstract class Or_Fruit_And<T> : Lnk_Fruit_Lnk<T, IDisjunct, IConjunct>;
public abstract class And_Fruit_And<T> : Lnk_Fruit_Lnk<T, IConjunct, IConjunct>;
public abstract class And_Fruit_Or<T> : Lnk_Fruit_Lnk<T, IConjunct, IDisjunct>;
