using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;
public static class Temperature
{
    public static ITempEdit<N> Kelvin<N>(N value) where N : INumber<N> => new Temperature<N> { Kelvin = value };
    public static ITempEdit<N> Celsius<N>(N value) where N : INumber<N> => new Temperature<N> { Celsius = value };
    public static ITempEdit<N> Fahrenheit<N>(N value) where N : INumber<N> => new Temperature<N> { Fahrenheit = value };
}
