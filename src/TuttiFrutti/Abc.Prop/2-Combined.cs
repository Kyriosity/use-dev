using Abc.Ltd;

namespace Abc.Item;
public interface IMaxItem<T> : IProped<T>, IUpper<T> { }
public interface IMaxItemed<T> : IProped<T>, IUpper<T> { }

public interface IActedItem<T, TA> : IProped<T>, IActed<TA> { }
