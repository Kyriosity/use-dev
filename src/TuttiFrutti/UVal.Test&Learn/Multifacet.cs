using System.Numerics;
namespace UVal.Test_Learn;

public interface IMultifacet<T> { }

public interface IMultifacet<T, U> : IMultifacet<T>
{
    T this[U unit] { get; }
    T Core { get; } // = NotImplemented.ToDo("Delete");
}

public interface IOpenMultifacet<T, U> : IMultifacet<T, U>
{
    new T this[U unit] { get; set; }
}

public interface IUValue<T, U> : IOpenMultifacet<T, U> where U : Enum;

public interface IUNum<N, U> : IUValue<N, U> where N : INumber<N> where U : Enum;