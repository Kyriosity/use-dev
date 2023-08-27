using Abc.Err.Sys;
using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;
public static class Temperature
{
    public static ITempEdit<N> Kelvin<N>(N value) where N : INumber<N> => new Temperature<N> { Kelvin = value };
    public static ITempEdit<N> Celsius<N>(N value) where N : INumber<N> => new Temperature<N> { Celsius = value };
    public static ITempEdit<N> Fahrenheit<N>(N value) where N : INumber<N> => new Temperature<N> { Fahrenheit = value };
    public static ITemp<N> Const<N>(N kelvin, N celsius, N fahrenheit) where N : INumber<N> =>
        new ConstTemp<N>() { Kelvin = kelvin, Celsius = celsius, Fahrenheit = fahrenheit };
}

readonly struct ConstTemp<N> : ITemp<N> where N : INumber<N>
{
    public N this[In unit] => From(unit);

    public required N Kelvin { get; init; }

    public required N Celsius { get; init; }

    public required N Fahrenheit { get; init; }

    private N From(In unit) {
        if (In.Kelvin == unit)
            return Kelvin;
        if (In.Celsius == unit)
            return Celsius;
        if (In.Fahrenheit == unit)
            return Fahrenheit;

        return Argument<In>.Throw(unit.ToString());
    }
}