namespace AbcDataOps.ISie;
public static class Extensions
{
    public static IStringMenu Is(this string val) => null;
}

public interface IStringMenu
{
    IEmptyOptions NullOr { get; }
    ISpaceTraits EmptyOr { get; }
    bool Latin { get; }
    bool LatinNumeric { get; }
    bool Ascii { get; }
}


public interface IEmptyOptions
{
    bool Empty { get; }
    ISpaceTraits EmptyOr { get; }
}


public interface ISpaceTraits
{
    bool Whitespace { get; }
    bool SingleSpace { get; }
    bool Spaces { get; }
}

public interface IPure
{
    bool Only { get; }
}