using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;
public static class Temperature
{
    public static ITempEdit<N> Kelvin<N>(N value) where N : INumber<N> => new Temperature<N> { Kelvin = value };
    public static ITempEdit<N> Celsius<N>(N value) where N : INumber<N> => new Temperature<N> { Celsius = value };
    public static ITempEdit<N> Fahrenheit<N>(N value) where N : INumber<N> => new Temperature<N> { Fahrenheit = value };

    public static class Const
    {
        public static ITemp<N> KeCeFa<N>(N kelvin, N celsius, N fahrenheit) where N : INumber<N> => new ConstTemp<N>() { Kelvin = kelvin, Celsius = celsius, Fahrenheit = fahrenheit };
        public static ITemp<N> Kelvin<N>(N value) where N : INumber<N> => Constant(Temperature.Kelvin(value));
        public static ITemp<N> Celsius<N>(N value) where N : INumber<N> => Constant(Temperature.Celsius(value));
        public static ITemp<N> Fahrenheit<N>(N value) where N : INumber<N> => Constant(Temperature.Fahrenheit(value));

        private static ITemp<N> Constant<N>(ITemp<N> temp) where N : INumber<N> =>
            new ConstTemp<N>() { Kelvin = temp.Kelvin, Celsius = temp.Celsius, Fahrenheit = temp.Fahrenheit };
    }
}

