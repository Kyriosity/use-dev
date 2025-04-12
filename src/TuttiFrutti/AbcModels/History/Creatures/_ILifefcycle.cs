namespace AbcModels.History.Creatures;
public interface ILifecycle<T> : ITimelineAttributed<T, string>// ToDo: where T Bag with EVENT ?
{
    T? Birth { get; }
}

//public interface ILifecycle_Init<T> : ILifecycle<T>
//{
//    new T? Birth { get; init; }
//}

public interface ILifecycle_Edit<T> : ILifecycle<T>
{
    new T? Birth { get; set; }
}