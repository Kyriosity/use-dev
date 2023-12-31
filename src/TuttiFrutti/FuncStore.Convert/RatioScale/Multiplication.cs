using System.Numerics;
namespace FuncStore.Convert.RatioScale;
public class Multiplication<U> : IFuncStore<U> where U : Enum, IConvertible
{
    public Func<N, N> For<N>(U from, U to) where N : INumber<N> {
        var multiplier = from.ToInt64(null);
        var divider = to.ToInt64(null);

        return x => {
            var calcAccu = double.CreateChecked(x);
            calcAccu = 0 < divider ? calcAccu / divider : calcAccu * -divider;
            calcAccu = 0 < multiplier ? calcAccu * multiplier : calcAccu / -multiplier;
            return N.CreateChecked(calcAccu);
        };
    }
}

