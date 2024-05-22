namespace AbcExt.Errors.Data;

public class UniqueConstraint(string message)
    : DataException<UniqueConstraint>(message);

