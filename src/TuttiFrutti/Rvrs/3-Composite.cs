using Abc.Coll;
using Abc.Item;

namespace Rvrs;

public interface IItem : IDistinct, IReversible { }

public interface IItem<T> : IReversible { }
public interface IUndoItem<T> : IItem<T>, IMutable<T>, IBack { }
public interface IUndoRedoItem<T> : IUndoItem<T>, IForth { }


public interface IReversibleOnColl<T, TColl> : IItem<T> where TColl : IItemsAccu<T>
{
    TColl Coll { get; }
}

public interface IUndo<T, TColl> : IBack, IReversibleOnColl<T, TColl> where TColl : IItemsAccu<T> { }

public interface IUndoRedo<T, TColl> : IForth, IUndo<T, TColl> where TColl : IItemsAccu<T> { }

public interface IUndoRedo_AllIn<T, TColl> : IBackForth_AllIn<T>, IReversibleOnColl<T, TColl> where TColl : IItemsAccu<T> { }
