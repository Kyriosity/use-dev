namespace AbcStoppers.Errors.Data;

public class EntityNotFound(string message) :
    Exception<EntityNotFound>(message),
    IHasAmbiguousSignature;
