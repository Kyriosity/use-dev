namespace Funcware.Numeric.SameType.InUnit.Ratio;

public class Exponent<U> : Funcware.Numeric.SameType.InUnit.IProvider<U>
    where U : Enum, IConvertible
{
    protected int ExponentBase => _exponentBase;
    private readonly int _exponentBase;

    public Exponent() {
        if (!ExponentAttribute.From(typeof(U), out _exponentBase))
            Argument<U>.Throw($"Missing: {nameof(ExponentAttribute)}");
    }

    public Func<N, N> For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        if (from.Equals(to))
            return x => x;

        var fromPower = from.ToInt64(null);
        var toPower = to.ToInt64(null);

        return x => {
            var exponentPower = fromPower - toPower;
            var factor = Math.Pow(ExponentBase, exponentPower);
            return N.CreateChecked(double.CreateChecked(x) * factor);
        };
    }
}
