using System.Numerics;
namespace N_Val.Phys.Temperature.Measured;

public interface UVal<N> : UValue<N> where N : INumber<N> { }
