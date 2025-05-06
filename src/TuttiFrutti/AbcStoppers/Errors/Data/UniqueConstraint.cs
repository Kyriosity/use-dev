namespace AbcStoppers.Errors.Data;

public class UniqueConstraint(string message)
    : Exception<UniqueConstraint>(message),
    IHasAmbiguousSignature;

