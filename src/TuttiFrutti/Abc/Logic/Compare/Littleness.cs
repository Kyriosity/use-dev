namespace Abc.Logic.Compare;
public interface ILittleness<T> : ITruthValuing;

public interface ILesser : ILittleness<bool>;
public interface IGreaterOrEqual : ILittleness<bool>;
