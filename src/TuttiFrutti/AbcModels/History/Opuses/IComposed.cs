namespace AbcModels.History.Opuses;

public interface IComposed : ITimeline;

public interface IComposed<T> : IComposed, ITimeline<T>
{
    T? Started { get; }
    T? Finished { get; }
    T? Released { get; }
}

public interface IComposed_Init<T> : IComposed<T>
{
    new T? Started { get; init; }
    new T? Finished { get; init; }
    new T? Released { get; init; }
}

public interface IComposed_Edit<T> : IComposed<T>
{
    new T? Started { get; set; }
    new T? Finished { get; set; }
    new T? Released { get; set; }
}

