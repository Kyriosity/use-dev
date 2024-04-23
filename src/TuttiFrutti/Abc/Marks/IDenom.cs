namespace Abc.Marks;
public interface IDenom : IBasal;

public interface IDenom<T> : IBasal<T>, IDenom
{
    T Name { get; }
}

public interface IDenom_Edit<T> : IDenom<T>
{
    new T Name { get; set; }
}
