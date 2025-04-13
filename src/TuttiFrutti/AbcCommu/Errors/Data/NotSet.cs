namespace AbcCommu.Errors.Data;

public class NotSet(string message)
    : Exception<NotSet>(message),
    IHasAmbiguousSignature;