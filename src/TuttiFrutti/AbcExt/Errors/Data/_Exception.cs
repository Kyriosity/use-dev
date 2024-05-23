namespace AbcExt.Errors.Data;

public abstract class Exception<TExc>(string message) : AbcException<TExc>(message)
    where TExc : Exception;