using Imp.Rvrs;

namespace Rvrs.Mk;

public abstract class IOutput
{
    public abstract IReversible Of<T>(T done);
    public abstract IReversible Of<T>(params T[] done);
}


public abstract class IOutput_AHEAD
{
    public virtual IReversible Of<T>(T done, params T[] undone) => Of(new T[] { done }, undone);
    public abstract IReversible Of<T>(IEnumerable<T> done, params T[] undone);
}

public class UndoOnly : IOutput
{
    public override IUndoItem<T> Of<T>(T done) => new UndoOnlyItem<T> { Value = done };

    public override IUndoItem<T> Of<T>(params T[] done) {
        var item = new UndoOnlyItem<T>();
        foreach (var value in done)
            item.Value = value; // ToDo: must be another way of :silent: init with adjust
        return item;
    }
}

public class UndoRedo : UndoOnly
{
    public override IUndoRedoItem<T> Of<T>(T done) => new UndoRedoItem<T> { Value = done };
    public override IUndoRedoItem<T> Of<T>(params T[] done) => NotImplemented.Throw("prototype only");
}