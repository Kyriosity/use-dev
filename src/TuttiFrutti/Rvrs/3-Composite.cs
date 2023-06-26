using Abc.Coll;

namespace Rvrs;

public interface IReversibleItem<T> : IReversible
{
    T Item { get; }
}

public interface IReversible<T> : IReversibleItem<T>
{
    new T Item { get; set; }
}


public interface IReversible<T, TColl> : IReversible<T> where TColl : IItemsAccu<T>
{
    TColl Coll { get; }
}

public interface IUndo<T, TColl> : IBack, IReversible<T, TColl> where TColl : IItemsAccu<T> { }

public interface IUndoRedo<T, TColl> : IForth, IUndo<T, TColl> where TColl : IItemsAccu<T> { }

public interface IUndoRedo_AllIn<T, TColl> : IBackForth_AllIn<T>, IReversible<T, TColl> where TColl : IItemsAccu<T> { }
