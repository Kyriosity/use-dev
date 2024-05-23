using System.ComponentModel;

namespace AbcExt.Errors.Sys;

// EXPERIMENTAL: so far it's arguable if there're use cases for this wrapper
public class InvalidEnumArgument : Multiparameter<InvalidEnumArgumentException>
{
    private InvalidEnumArgument() { /* to prevent direct instantiation */ }
}
