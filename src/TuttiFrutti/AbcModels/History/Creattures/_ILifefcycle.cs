namespace AbcModels.History.Creattures;
public interface ILifefcycle<T> : ITimelineAttributed<T, string>

// ToDo: where T Bag with EVENT ?
{
    T? Birth { get; }
}

//public interface ILifefcycle_Init<T> : ILifefcycle<T>
//{
//    new T? Birth { get; init; }
//}

public interface ILifefcycle_Edit<T> : ILifefcycle<T>
{
    new T? Birth { get; set; }
}
