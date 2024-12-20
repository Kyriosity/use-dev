﻿using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature;

public abstract class ClosedTemp<N, F> : FuncWiredValues<N, In, F>, ITemperature<N> where N : INumber<N> where F : IFuncStore<In>, new()
{
    public N this[In unit] => Get(unit);
    public N Kelvin => NotImplemented.Throw("prototype only");
    public N Celsius => NotImplemented.Throw("prototype only");
    public N Fahrenheit => NotImplemented.Throw("prototype only");
}

public class Temp<N, F> : ClosedTemp<N, F>, ITempEdit<N> where N : INumber<N> where F : IFuncStore<In>, new()
{
    public N this[In unit] { get => Get(unit); set => Set(value, unit); }

    public new N Kelvin { get => Get(In.Kelvin); set => Set(value, In.Kelvin); }
    public new N Celsius { get => Get(In.Celsius); set => Set(value, In.Celsius); }
    public new N Fahrenheit { get => Get(In.Fahrenheit); set => Set(value, In.Fahrenheit); }
}