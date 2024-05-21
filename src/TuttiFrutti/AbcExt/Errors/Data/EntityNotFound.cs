namespace AbcExt.Errors.Data;

public class EntityNotFound(string message)
    : Shortcut<EntityNotFound>(message);

