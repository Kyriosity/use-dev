using AbcExt.Errors.Sys;
using MeasUnits.Metadata;

namespace FuncStore.Conversion.RatioScale;

public class Exponentiation<U> : IFuncStore<U> where U : Enum, IConvertible
{
    public Exponentiation() {
        if (!ExponentAttribute.From(typeof(U), out _exponentBase))
            Argument<U>.Throw($"Missing: {nameof(ExponentAttribute)}");
    }
    protected int ExponentBase => _exponentBase;
    private readonly int _exponentBase;

    public Func<N, N> For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        return x => {
            var fromNumd = from.ToInt64(null);
            var toNumd = to.ToInt64(null);

            if (fromNumd == toNumd)
                return x;

            var exponentPower = fromNumd - toNumd;
            var factor = Math.Pow(ExponentBase, exponentPower);
            return N.CreateChecked(double.CreateChecked(x) * factor);
        };
    }
}