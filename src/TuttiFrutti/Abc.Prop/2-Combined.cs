using Abc.Ltd;

namespace Abc.Item;
public interface IMaxItem<T> : IGet<T>, IUpper<T> { }
public interface IMaxItemed<T> : IGet<T>, IUpper<T> { }

public interface IActedItem<T, TA> : IGet<T>, IActed<TA> { }
