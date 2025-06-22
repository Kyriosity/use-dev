namespace AbcLingua.Rules.Numeric;
public interface IRank
{
    bool IsOrdinal { get; } // e.g. "zeroth", "twenty first"
}

public interface IRank_Edit : IRank
{
    new bool IsOrdinal { get; set; }
}