namespace AbcExt.Errors.Data;

public class UniqueConstraint(string message)
    : Argument.Shortcut<UniqueConstraint>(message);

