namespace AbcModels.History.Creatures;
public interface IHuman<T> : ILifecycle<T>
{
    T? LastMarried { get; }
    T? Graduated { get; }
}
