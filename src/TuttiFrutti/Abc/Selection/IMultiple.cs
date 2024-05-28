namespace Abc.Selection;
public interface IMultiple<T>
{
    T[] Index { get; } // ensure unique values only
}


public interface INdexed<N> : IMultiple<N> where N : INumber<N>;

public interface INdexed : INdexed<int>;
