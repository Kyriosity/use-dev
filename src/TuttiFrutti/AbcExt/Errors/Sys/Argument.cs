using AbcExt.Errors.Shortcuts;

namespace AbcExt.Errors.Sys;
public class Argument : Multiparameter<ArgumentException> // ToDo: CHANGE !
{
    private Argument() { /* to prevent direct instantiation */ }
}
