namespace Abc.Logic.Predicate;
public interface IEquality<T> : ITruthValuing;

public interface IEqual : IEquality<bool>;
public interface INotEqual : IEquality<bool>;


public interface ICompare<in T, Plug> : ITruthValuing where Plug : AbcCircuitry.Bool.IO
{
    public bool Compare(T left, T right);
}