namespace Abc.Logic.Compare;
public interface Equality<T> : ITruthValuing;

public interface IEqual : Equality<bool>;
public interface INotEqual : Equality<bool>;


public interface ICompare<in T, Plug> : ITruthValuing where Plug : Circuitry.Bool.IO
{
    public bool Op(T left, T right);
}