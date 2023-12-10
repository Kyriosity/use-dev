namespace Abc.Ext.Errors.Data;
public class Inconsistency : Exception
{
    public Inconsistency(string? message = "", Exception? inner = null) : base(message, inner) { }

    public static dynamic Throw(string? message = "", Exception? inner = null) => throw new Inconsistency(message, inner);
}
