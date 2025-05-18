using Abc.Logic.Circuitry;
using AbcRefl.Implementation;
using WizConstr.Xform;

namespace ISie.Mk;
public abstract class Root<T, IO> : Core<T, bool>
    where IO : Circuitry.IO
{
    internal Root(T seed) {
        Seed = seed;
        Circuitry = Unpack();
    }

    private static Func<bool, bool> Unpack() =>
        arg => (bool)Method.Default<IO>(nameof(IOWire<T>.Plug)).Invoke(arg); // ToDesign: unpack once to dynamic method (or cache)

}