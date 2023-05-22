namespace Abc;
public interface ISelect
{
    int Index { get; }
}

public interface ISelected : ISelect
{
    new int Index { get; init; }
}

public interface ISelectable : ISelect
{
    new int Index { get; set; }
}
