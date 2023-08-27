using Abc.Err.Sys;
using Mk.N_Val.Phys.Temperature.Conversions;
using N_Val;
using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature;

public abstract class ConstTemperature<N> : WiredValues<N, In>, ITemp<N> where N : INumber<N>
{
    public N this[In unit] => Get(unit);
    public N Kelvin => NotImplemented.Throw();
    public N Celsius => NotImplemented.Throw();
    public N Fahrenheit => NotImplemented.Throw();
}

public class Temperature<N> : ConstTemperature<N>, ITempEdit<N> where N : INumber<N>
{
    public new N this[In unit] { get => Get(unit); set => Set(value, unit); }

    public new N Kelvin { get => Get(In.Kelvin); set => Set(value, In.Kelvin); }
    public new N Celsius { get => Get(In.Celsius); set => Set(value, In.Celsius); }
    public new N Fahrenheit { get => Get(In.Fahrenheit); set => Set(value, In.Fahrenheit); }
    protected override IConversion<N, In> Conversion => new TemperatureFunctions<N>();
}