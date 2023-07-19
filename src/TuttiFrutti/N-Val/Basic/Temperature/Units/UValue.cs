using System.Numerics;

namespace N_Val.Basic.Temperature.Units;
public interface UValue<N> : UValues<N> where N : INumber<N> { }
