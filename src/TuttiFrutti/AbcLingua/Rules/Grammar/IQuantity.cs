namespace AbcLingua.Rules.Grammar;
public interface IQuantity
{
    Quantity Plurality { get; }
}

public interface IQuantity_Edit : IQuantity
{
    new Quantity Plurality { get; set; }
}

