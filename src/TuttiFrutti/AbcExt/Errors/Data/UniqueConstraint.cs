namespace AbcExt.Errors.Data;

public class UniqueConstraint(string? message = "", Exception? inner = null)
    : Shortcuts.Direct<UniqueConstraint>(message, inner);

