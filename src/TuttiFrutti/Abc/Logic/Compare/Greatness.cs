namespace Abc.Logic.Compare;
public interface IGreatness<T> : ITruthValuing;

public interface IGreater : IGreatness<bool>;
public interface ILessOrEqual : IGreatness<bool>;
