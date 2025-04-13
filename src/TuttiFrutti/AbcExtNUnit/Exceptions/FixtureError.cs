using AbcCommu.Errors.Utils;

namespace AbcExtNUnit.Exceptions;

public class FixtureError(string message) :
    AbcCommu.Errors.Basal.Exception<FixtureError>(message),
    IHasAmbiguousSignature;
