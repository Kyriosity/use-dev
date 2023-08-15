using System.Numerics;
namespace N_Val.Phys.Temperature.Measured;

public interface ICelsius<out N> : UVal<N> where N : INumber<N> { N Celsius { get; } }
public interface IInitCelsius<N> : ICelsius<N> where N : INumber<N> { new N Celsius { get; init; } }
public interface IMutableCelsius<N> : ICelsius<N> where N : INumber<N> { new N Celsius { get; set; } }
