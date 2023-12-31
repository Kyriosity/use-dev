namespace FuncStore.Convert.RatioScale;

public abstract class Exponentiation<U>(double exponentBase) : IFuncStore<U> where U : Enum, IConvertible
{
    protected double ExponentBase { get; } = exponentBase;

    public Func<N, N> For<N>(U from, U to) where N : System.Numerics.INumber<N> {
        return x => {
            var exponentPower = from.ToInt64(null) - to.ToInt64(null);
            var factor = System.Math.Pow(ExponentBase, exponentPower);
            return N.CreateChecked(double.CreateChecked(x) * factor);
        };
    }
}


// ToDo: read POWER from ATTRIBUTE
public class DecimalExponenting<U> : Exponentiation<U> where U : Enum, IConvertible { public DecimalExponenting() : base(10) { } }

public class BinaryExponenting<U> : Exponentiation<U> where U : Enum, IConvertible { public BinaryExponenting() : base(2) { } }