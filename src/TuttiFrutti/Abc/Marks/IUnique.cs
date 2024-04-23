namespace Abc.Marks;

public interface IUnique;
public interface IUnique<T> : IBasal<T>, IUnique
{
    T Id { get; }
}

public interface IUnique_Edit<T> : IUnique<T>
{
    new T Id { get; set; }
}

