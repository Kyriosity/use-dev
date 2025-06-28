namespace AbcExtNUnit.AssertOnAssign.setup;

public abstract class TMidKey
{
    internal static readonly Type _type = typeof(TMidKey);
}

public class Mid<T>
{
    private Mid() { }

    public static implicit operator Mid<T>?(double? num) {
        Proc<double?>.Report<T>(num);
        return new Mid<T>();
    }

    public static implicit operator Mid<T>?(bool? val) {
        Proc<bool?>.Report<T>(val);
        return new Mid<T>();
    }

    public static implicit operator Mid<T>?(string? text) {
        Proc<string?>.Report<T>(text);
        return new Mid<T>();
    }

    // PARAMETRIZE ? TO OVERLOAD FOR CUSTOM ?
}