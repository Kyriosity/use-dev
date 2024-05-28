namespace AbcModels.History.Opuses;
public interface IIssued<T> : IComposed<T>
{
    T? Published { get; }
}

public interface IIssued_Init<T> : IIssued<T>
{
    new T? Published { get; init; }
}

public interface IIssued_Edit<T> : IIssued<T>
{
    new T? Published { get; set; }
}
