using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;
public static class Temperature
{
    public static ITemperature<N> Kelvin<N>(N value) where N : INumber<N> => new Temperature<N> { Kelvin = value };
    public static ITemperature<N> Celsius<N>(N value) where N : INumber<N> => new Temperature<N> { Celsius = value };
    public static ITemperature<N> Fahrenheit<N>(N value) where N : INumber<N> => new Temperature<N> { Fahrenheit = value };

    public static ITemperatureIssue Const { get; }
}


public interface ITemperatureIssue
{
    public ITemperature<N> Fahrenheit<N>(N value) where N : INumber<N>;
}
