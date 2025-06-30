namespace AbcLingua.Rules.Grammar.Quantity;
public interface IEdit : IRead
{
    new Values Quantity { get; set; }
}