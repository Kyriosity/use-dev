using Abc.Mk.Coll;
using Rvrs;

namespace Imp.Rvrs;

public class UndoOnlyItem<T> : IUndoItem<T>
{

    // ToDo: make adjustable !

    public T? Value {
        get => _coll[_coll.Items.Count - 1];
        set {
            _coll.Add(value);
        }
    }

    public int StepsUndo() => _coll.Items.Count;

    public void Undo(int steps = 1) => _coll.RemoveLast(steps);

    private ListAccu<T?> _coll = new ListAccu<T?>(); // ToDo: interface
}


public class UndoRedoItem<T> : UndoOnlyItem<T>, IUndoRedoItem<T>
{
    public void Redo(int steps = 1) {
        throw new NotImplementedException();
    }

    public int StepsRedo() {
        throw new NotImplementedException();
    }
}