using AbcExt.Refl;

namespace AbcExt.Errors.Data;

public abstract class Exception<TExc>(string message) : AbcException<TExc>(message) // ToDo: rename TExc to Exc
    where TExc : Exception

{
    public static dynamic Throw() => Throw(Caller.Report());
}
