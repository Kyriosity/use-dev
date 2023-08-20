using N_Val.Phys.Temperature;
using System.Numerics;

namespace Mk.N_Val.Phys.Temperature.Build;
public interface IResultOutput
{
    ITemp<N> Celsius<N>() where N : INumber<N>;
    IValueOuput this[In unit] => new ValueOutput(unit);
}

public interface IValueOuput
{
    ITemp<N> Of<N>(N value) where N : INumber<N>;
}

public class ValueOutput : IValueOuput
{
    private readonly In _unit;
    public ValueOutput(In unit) {
        _unit = unit;
    }

    public ITemp<N> Of<N>(N value) where N : INumber<N> {
        var product = new Temperature<N>();
        product.Set(value, _unit);
        return product;
    }
}


