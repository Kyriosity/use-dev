﻿namespace N_Val;

public interface IMultifacetValue<T> { }

public interface IValueByUnit<T, U> : IMultifacetValue<T> where U : Enum
{
    public T Get(out U unit);
    public T Get(U unit);
    public void Set(T value, U unit);
}