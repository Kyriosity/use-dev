namespace AbcModels.History.Creattures;
public interface IHuman<T> : ILifefcycle<T>
{
    T? LastMarried { get; }
    T? Graduated { get; }
}
