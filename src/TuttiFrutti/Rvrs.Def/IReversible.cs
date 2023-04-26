namespace Rvrs.Def;

public interface IReversible { }

public interface IBackward : IReversible
{
    void Undo();
    int StepsUndo();
}

public interface IBackAndForth : IBackward
{
    void Redo();
    int StepsRedo();
}

public interface IBackwardTill : IReversible
{
    int Undo(DateTime till);
    int StepsUndo(DateTime till);
}

public interface IBackAndForthTill : IBackwardTill
{
    int Redo(DateTime till);
    int StepsRedo(DateTime till);
}

public interface IBackwardProvided<T> : IReversible
{
    int Undo(Predicate<T> till);
    int StepsUndo(Predicate<T> till);
}

public interface IBackAndForthProvided<T> : IBackwardProvided<T>
{
    int Redo(Predicate<T> till);
    int StepsRedo(Predicate<T> till);
}