using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;

[Obsolete]
public static class Temperature<F> where F : IFuncStore<In>, new()
{
    public static ITempEdit<N> Kelvin<N>(N value) where N : INumber<N> => new Temp<N, F> { Kelvin = value };
    public static ITempEdit<N> Celsius<N>(N value) where N : INumber<N> => new Temp<N, F> { Celsius = value };
    public static ITempEdit<N> Fahrenheit<N>(N value) where N : INumber<N> => new Temp<N, F> { Fahrenheit = value };
}
