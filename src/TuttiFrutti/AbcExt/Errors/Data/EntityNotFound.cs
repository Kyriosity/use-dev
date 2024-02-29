namespace AbcExt.Errors.Data;

public class EntityNotFound(string? message = "", Exception? inner = null)
    : Shortcuts.Regular<EntityNotFound>(message, inner);

