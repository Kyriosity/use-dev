namespace AbcExt.Errors.Data;

public class NotSet(string message)
    : DataException<NotSet>(message);
