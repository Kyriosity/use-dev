using System.Numerics;
namespace N_Val.Phys.Temperature.Measured;

public interface UVal<out N> : UValue<N> where N : INumber<N> { }
