using N_Val.Phys.Temperature.Measured;
using System.Numerics;

namespace N_Val.Phys.Temperature;
public interface ITemp<N> : IKelvin<N>, ICelsius<N>, IFahrenheit<N> where N : INumber<N>
{
    N this[In unit] { get; }
}
public interface ITempInit<N> : ITemp<N>, IInitKelvin<N>, IInitCelsius<N>, IInitFahrenheit<N> where N : INumber<N> { }
public interface ITempEdit<N> : ITemp<N>, IMutableKelvin<N>, IMutableCelsius<N>, IMutableFahrenheit<N> where N : INumber<N>
{
    new N this[In unit] { get; set; }
}
