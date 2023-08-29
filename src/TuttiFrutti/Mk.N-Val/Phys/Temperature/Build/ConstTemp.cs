using Abc.Err.Sys;
using N_Val.Phys.Temperature;
using System.Numerics;

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