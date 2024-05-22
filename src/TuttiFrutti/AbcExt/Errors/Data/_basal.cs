using AbcExt.Errors.Shortcuts;
namespace AbcExt.Errors.Data;

public abstract class DataException<TExc>(string message) : Regular<TExc>(message)
    where TExc : Exception;