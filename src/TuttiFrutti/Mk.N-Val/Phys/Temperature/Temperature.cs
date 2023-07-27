using Mk.N_Val.Phys.Temperature.Conversions;
using N_Val;
using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature;
public class Temperature<N> : WiredValues<N, Unit>, ITemperature<N> where N : INumber<N>
{
    public N Kelvin { get => Get(Unit.Kelvin); set => Set(value, Unit.Kelvin); }
    public N Celsius { get => Get(Unit.Celsius); set => Set(value, Unit.Celsius); }
    public N Fahrenheit { get => Get(Unit.Fahrenheit); set => Set(value, Unit.Fahrenheit); }

    protected override IConversion<N, Unit> Conversion => new TemperatureFunctions<N>();
}

