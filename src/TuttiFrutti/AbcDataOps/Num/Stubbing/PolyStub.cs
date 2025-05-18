using AbcDataOps.Num.Is;

namespace AbcDataOps.Num.Stubbing;
public class PolyStub<N>(N value) : IBinary where N : INumber<N>
{
    public N Value => value;

    public Func<bool> IsPow2 {
        get => _isPow2 ?? throw new InvalidOperationException($"{nameof(IsPow2)} on {typeof(N).FullName}");
        internal protected init { _isPow2 = value; }
    }
    private Func<bool> _isPow2 = null;

    public Func<bool> IsNaturalOr0 => () => N.IsInteger(Value) && N.Zero <= Value;

    public Func<bool> IsNaN => () => N.IsNaN(Value);
}

// ToDesign: derive classes for BigInteger