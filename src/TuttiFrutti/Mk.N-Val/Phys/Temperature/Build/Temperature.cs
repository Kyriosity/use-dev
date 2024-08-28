using Mk.N_Val.Phys.Temperature.Build.Const;
using Mk.N_Val.Phys.Temperature.Wiring;
using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;

[Obsolete]
public static class Temperature
{
    public static ITempEdit<N> Kelvin<N>(N value) where N : INumber<N> => Temperature<UniDirect>.Kelvin(value);
    public static ITempEdit<N> Celsius<N>(N value) where N : INumber<N> => Temperature<UniDirect>.Celsius(value);
    public static ITempEdit<N> Fahrenheit<N>(N value) where N : INumber<N> => Temperature<UniDirect>.Fahrenheit(value);

    public static class Const
    {
        public static ITemperature<N> All<N>(N kelvin, N celsius, N fahrenheit) where N : INumber<N> => new Stub<N> { Kelvin = kelvin, Celsius = celsius, Fahrenheit = fahrenheit };
        public static ITemperature<N> Kelvin<N>(N value) where N : INumber<N> => From(Temperature.Kelvin(value));
        public static ITemperature<N> Celsius<N>(N value) where N : INumber<N> => From(Temperature.Celsius(value));
        public static ITemperature<N> Fahrenheit<N>(N value) where N : INumber<N> => From(Temperature.Fahrenheit(value));

        private static ITemperature<N> From<N>(ITemperature<N> temp) where N : INumber<N> => new Stub<N>() {
            Kelvin = temp.Kelvin, Celsius = temp.Celsius, Fahrenheit = temp.Fahrenheit
        };
    }
}