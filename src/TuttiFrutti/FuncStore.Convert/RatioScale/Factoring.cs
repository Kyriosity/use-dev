using System.Numerics;
namespace FuncStore.Convert.RatioScale;
public class Factoring<U> : IFuncStore<U> where U : Enum, IConvertible
{
    public Func<N, N> For<N>(U from, U to) where N : INumber<N> {
        var multiplier = from.ToInt64(null);
        var divider = to.ToInt64(null);

        return x => {
            var resAccu = double.CreateChecked(x);
            resAccu = 0 < divider ? resAccu / divider : resAccu * -divider;
            resAccu = 0 < multiplier ? resAccu * multiplier : resAccu / -multiplier;
            return N.CreateChecked(resAccu);
        };
    }
}
