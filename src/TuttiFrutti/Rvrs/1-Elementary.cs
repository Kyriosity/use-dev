namespace Rvrs;

public interface IReversible { }

public interface IBack : IReversible
{
    void Undo();
    int StepsUndo();
}

public interface IForth : IReversible
{
    void Redo();
    int StepsRedo();
}

public interface IBackTimed : IReversible
{
    int Undo(DateTime after);
    int StepsUndo(DateTime after);
}

public interface IForthTimed : IReversible
{
    int Redo(DateTime before);
    int StepsRedo(DateTime before);
}

public interface IBackConditional<T> : IReversible
{
    int Undo(Predicate<T> till);
    int StepsUndo(Predicate<T> till);
}

public interface IForthConditional<T> : IReversible
{
    int Redo(Predicate<T> till);
    int StepsRedo(Predicate<T> till);
}