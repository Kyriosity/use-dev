using N_Val.Phys.Temperature.Measured;
using System.Numerics;

namespace N_Val.Phys.Temperature;
public interface ITemperatureReadonly<N> : IKelvin<N>, ICelsius<N>, IFahrenheit<N> where N : INumber<N> { }
public interface ITemperatureConst<N> : IInitKelvin<N>, IInitICelsius<N>, IInitFahrenheit<N> where N : INumber<N> { }
public interface ITemperature<N> : IMutableKelvin<N>, IMutableCelsius<N>, IMutableFahrenheit<N> where N : INumber<N> { }
