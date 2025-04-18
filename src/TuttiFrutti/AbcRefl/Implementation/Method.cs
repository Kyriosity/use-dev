using AbcRefl.Scripting;

namespace AbcRefl.Implementation;
public class Method
{
    private Method(Type declType, string name, Type[]? signature) {
        _name = name;
        _declType = declType;
        _method = signature is null
            ? declType.GetMethod(name)
            : declType.GetMethod(name, signature);

    }

    private readonly Type _declType;
    private readonly string _name;
    private readonly MethodInfo? _method;


    private object? Dummy {
        get {
            field ??= Runtime.Dummy.Compile(_declType); return field;
        }
    }

    public static Method Default<I>(string name, Type[]? signature = null) =>
        new(typeof(I), name, signature);

    public object? Invoke(params object?[] args) =>
        _method is null ?
            throw new ArgumentException($"{_declType.FullName}.{_name}(): not found") :
            _method.Invoke(Dummy, args);
}
