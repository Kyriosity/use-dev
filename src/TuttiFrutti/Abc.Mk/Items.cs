using Abc.Err.Sys;
namespace Abc.Mk;

public class SealedHolder<T> : IItem<T>
{
    public virtual T? Item => default;
}

public class ItemedHolder<T> : IItemed<T>
{
    public T? Item { get; init; }
}

public class Holder<T> : IMutableItem<T>
{
    public T? Item { get; set; }
}

public class AdjustedItem<T> : IMutableItem<T>
{
    public required Func<T?, T?> OnSet { get; init; } = _ => InvalidOperation.Throw($"{nameof(OnSet)}() must be set prior");
    public T? Item { get => _item; set => _item = OnSet(value); }
    private T? _item;
}

public class Accessor<T>
{
    protected T? _value;

    public T? Value {
        get {
            return _value;
        }
    }

    public static implicit operator T(Accessor<T> value) {
        return value.Value;
    }
}

public class Mutator<T> : Accessor<T>
{
    public int OnSet;

    new public T Value {
        get {
            return _value;
        }
        set {
            _value = value;
        }
    }

    public static implicit operator Mutator<T>(T value) {
        return new Mutator<T> { Value = value };
    }
}


