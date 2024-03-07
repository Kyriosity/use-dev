namespace AbcExt.Errors.Data;

public class EntityNotFound(string message)
    : Argument.Shortcut<EntityNotFound>(message);

