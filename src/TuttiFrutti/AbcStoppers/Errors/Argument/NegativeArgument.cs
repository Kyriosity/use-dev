using System.Numerics;

namespace AbcStoppers.Errors.Argument;
public class NegativeArgument(string message) : OutOfRange<NegativeArgument>(message),
    IHasAmbiguousSignature
{
    public static dynamic ThrowIf<N>(N subject, [ArgExpr(nameof(subject))] string argCall = "[<*unknown*>]")
        where N : INumber<N> =>
        N.Zero > subject ? Throw($"*{argCall}*={subject}") : 1;
}
