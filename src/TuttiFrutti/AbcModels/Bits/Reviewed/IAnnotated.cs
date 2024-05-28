namespace AbcModels.Bits.Reviewed;
public interface IAnnotated;

public interface IAnnotated<T> : IAnnotated
{
    T Note { get; }
}

public interface IAnnotated_Init<T> : IAnnotated<T>
{
    new T Note { get; init; }
}

public interface IAnnotated_Edit<T> : IAnnotated<T>
{
    new T Note { get; set; }
}

public interface ICommented : IAnnotated<string>;
public interface ICommented_Init : ICommented, IAnnotated_Init<string>;
public interface ICommented_Edit : ICommented, IAnnotated_Edit<string>;