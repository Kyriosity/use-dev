using Abc.Ext.Errors.Sys;
using System.Numerics;

namespace UVal.Test_Learn;
public static class UVal
{
    public static IOpenMultifacet<T, U> Of<T, U>(T value, U unit) where U : Enum =>
        NotImplemented.Throw(value, unit);
    public static IOpenMultifacet<T, U> Of<T, U>(T value, U unit, IFuncStore<U> func) where U : Enum =>
        NotImplemented.Throw(value, unit, func);

    public static class Const
    {
        public static IMultifacet<T, U> Of<T, U>(T value, U unit) where U : Enum =>
            NotImplemented.Throw(value, unit);
        public static IMultifacet<T, U> Of<T, U>(T value, U unit, IFuncStore<U> func) where U : Enum =>
            NotImplemented.Throw(value, unit, func);
    }
}

public class UVal<U> : UVal<U, DumbProporional<U>> where U : Enum { }
public class UVal<U, F> where U : Enum where F : IFuncStore<U>, new()
{
    public IOpenMultifacet<T, U> Of<T>(T value) => NotImplemented.Throw(value);
}

public interface IFuncStore<U>
{
    Func<N, N> For<N>(U from, U to) where N : INumber<N>;
}

public class DummyFuncStore<U> : IFuncStore<U>
{
    public Func<N, N> For<N>(U from, U to) where N : INumber<N> => NotImplemented.Throw();
}

public interface IProporionalFuncs<U> : IFuncStore<U>, IMathOpsEnabled // ToDo: SPLIT FOR CAR[?] FUNCS ?
{ }

public class DumbProporional<U> : IProporionalFuncs<U> where U : Enum, IConvertible
{
    public Func<N, N> For<N>(U from, U to) where N : INumber<N> {
        return x => x / N.CreateChecked(Convert.ToInt32(from)) * N.CreateChecked(Convert.ToInt32(to));
    }
}

public interface IMathOpsEnabled { }