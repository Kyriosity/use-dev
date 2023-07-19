using System.Numerics;

namespace N_Val.Basic.Temperature.Units;
public interface IFahrenheit<N> : UValue<N> where N : INumber<N> { N Fahrenheit { get; } }

public interface IInitFahrenheit<N> : IFahrenheit<N> where N : INumber<N> { new N Fahrenheit { get; init; } }

public interface IMutableFahrenheit<N> : IFahrenheit<N> where N : INumber<N> { new N Fahrenheit { get; set; } }