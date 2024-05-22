namespace AbcExt.Errors.Data;

public class EntityNotFound(string message)
    : DataException<EntityNotFound>(message);
