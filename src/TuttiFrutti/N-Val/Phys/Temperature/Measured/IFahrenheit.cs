using System.Numerics;
namespace N_Val.Phys.Temperature.Measured;

public interface IFahrenheit<N> where N : INumber<N> { N Fahrenheit { get; } }
public interface IInitFahrenheit<N> : IFahrenheit<N> where N : INumber<N>
{
    new N Fahrenheit { get; init; }
}
public interface IMutableFahrenheit<N> : IFahrenheit<N> where N : INumber<N>
{
    new N Fahrenheit { get; set; }
}