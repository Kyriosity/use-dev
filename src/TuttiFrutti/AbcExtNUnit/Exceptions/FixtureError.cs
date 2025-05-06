using AbcStoppers.Errors.Utils;

namespace AbcExtNUnit.Exceptions;

public class FixtureError(string message) :
    AbcStoppers.Errors.Basal.Exception<FixtureError>(message),
    IHasAmbiguousSignature;
