using AbcExt.Errors.Shortcuts;
using System.ComponentModel;

namespace AbcExt.Errors.Sys;

// so far it's arguable if there're use cases for this wrapper
public class InvalidEnumArgument : Multiparameter<InvalidEnumArgumentException>
{
    private InvalidEnumArgument() { /* to prevent direct instantiation */ }
}
