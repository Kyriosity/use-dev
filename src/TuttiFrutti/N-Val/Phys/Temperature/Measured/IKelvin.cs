using System.Numerics;
namespace N_Val.Phys.Temperature.Measured;

public interface IKelvin<N> : UVal<N> where N : INumber<N> { N Kelvin { get; } }
public interface IInitKelvin<N> : IKelvin<N> where N : INumber<N> { new N Kelvin { get; init; } }
public interface IMutableKelvin<N> : IKelvin<N> where N : INumber<N> { new N Kelvin { get; set; } }

