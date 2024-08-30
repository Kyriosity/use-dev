using AbcExt.Metadata.Ratio;

namespace FuncStore.Conversion.RatioScale;
public class Factoring<U> : IFuncStore<U> where U : Enum, IConvertible
{
    public Factoring() {
        var unitsType = typeof(U);

        if (!FactoredAttribute.From(unitsType).Any())
            Argument.Throw($"\"{unitsType.FullName}\" requires here explicit [{nameof(FactoredAttribute)}]");
    }

    public Func<N, N> For<N>(U from, U to) where N : INumber<N> {
        var fromNumd = from.ToInt64(null);
        var toNumd = to.ToInt64(null);
        var divider = from.ToInt64(null);

        return x => {
            if (fromNumd is 0 || toNumd is 0)
                Argument.Throw($"Neither factor can be zero ({nameof(from)}={from},{nameof(to)}={to})");

            if (fromNumd == toNumd)
                return x;

            var calcAccu = double.CreateChecked(x);

            // 1) *** ToDesign: avoid cAmEl calculations!
            // *** to know: how CLR deals with nums in chain
            // 2) ToDesign: prevent overflow by dividing first when applicable!
            if (1 != toNumd)
                calcAccu = 0 > toNumd ? calcAccu * -toNumd : calcAccu / toNumd;

            if (1 != fromNumd)
                calcAccu = 0 > fromNumd ? calcAccu / -fromNumd : calcAccu * fromNumd;

            return N.CreateChecked(calcAccu);
        };
    }
}