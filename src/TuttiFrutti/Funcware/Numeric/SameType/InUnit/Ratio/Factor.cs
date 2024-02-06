namespace Funcware.Numeric.SameType.InUnit.Ratio;
public class Factor<U> : Funcware.Numeric.SameType.InUnit.IProvider<U>
    where U : Enum, IConvertible
{
    public Factor() {
        var unitsType = typeof(U);

        if (!FactoredAttribute.From(unitsType).Any())
            Argument<U>.Throw($"Requires explicit {nameof(FactoredAttribute)}");
    }

    public Func<N, N> For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        if (from.Equals(to))
            return x => x;

        var fromFactor = from.ToInt64(null);
        var toFactor = to.ToInt64(null);

        return x => {
            if (fromFactor is 0 || toFactor is 0)
                Argument<U>.Throw($"Neither factor can be zero ({nameof(from)}={from},{nameof(to)}={to})");

            var calcAccu = double.CreateChecked(x);

            // ToDesign: avoid cAmEl calculations!
            // to know: how CLR deals with nums in chain
            // ToDesign: prevent overflow by dividing first when applicable!
            if (1 != toFactor)
                calcAccu = 0 > toFactor ? calcAccu * -toFactor : calcAccu / toFactor;

            if (1 != fromFactor)
                calcAccu = 0 > fromFactor ? calcAccu / -fromFactor : calcAccu * fromFactor;

            return N.CreateChecked(calcAccu);
        };
    }
}
