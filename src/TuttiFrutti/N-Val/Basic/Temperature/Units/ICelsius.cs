using System.Numerics;

namespace N_Val.Basic.Temperature.Units;
public interface ICelsius<N> : UValue<N> where N : INumber<N> { N Celsius { get; } }

public interface IInitICentigrade<N> : ICelsius<N> where N : INumber<N> { new N Celsius { get; init; } }

public interface IMutableICentigrade<N> : ICelsius<N> where N : INumber<N> { new N Celsius { get; set; } }
