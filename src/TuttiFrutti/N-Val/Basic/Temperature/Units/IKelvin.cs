using System.Numerics;

namespace N_Val.Basic.Temperature.Units;
public interface IKelvin<N> : UValue<N> where N : INumber<N> { N Kelvin { get; } }

public interface IInitKelvin<N> : IKelvin<N> where N : INumber<N> { new N Kelvin { get; init; } }

public interface IMutableKelvin<N> : IKelvin<N> where N : INumber<N> { new N Kelvin { get; set; } }
