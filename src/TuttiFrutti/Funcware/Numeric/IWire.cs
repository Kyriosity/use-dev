namespace Funcware.Numeric;
public interface IWire<in M> : IWire
{
    Func<T, Res> For<T, Res>(M from, M to) where T : INumber<T> where Res : INumber<Res>;
}
