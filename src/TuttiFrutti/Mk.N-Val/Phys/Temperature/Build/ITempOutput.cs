using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;
public interface IResultOutput
{
    ITemp<N> Celsius<N>() where N : INumber<N>;
    IValueOuput this[Unit unit] => new ValueOutput(unit);
}

public interface IValueOuput
{
    ITemp<N> Of<N>(N value) where N : INumber<N>;
}

public class ValueOutput : IValueOuput
{
    private readonly Unit _unit;
    public ValueOutput(Unit unit) {
        _unit = unit;
    }

    public ITemp<N> Of<N>(N value) where N : INumber<N> {
        var product = new Temperature<N>();
        product.Set(value, _unit);
        return product;
    }
}


