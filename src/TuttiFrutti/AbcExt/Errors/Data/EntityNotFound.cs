namespace AbcExt.Errors.Data;

public class EntityNotFound(string? message = "", Exception? inner = null) :
    Shortcuts.Direct<EntityNotFound>(message, inner);

