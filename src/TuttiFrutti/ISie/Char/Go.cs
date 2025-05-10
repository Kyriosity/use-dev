using Abc.Logic.Circuitry.Bool;
using ISie.Char.Is.Menus;

namespace ISie.Char;
public static class Go
{
    extension(char seed)
    {
        public IFull Is => new AllIncluded<IOWire>(seed);
        public IFull Not => new AllIncluded<IOInverter>(seed);
        public To.IMenu To => new To.Menu(seed);
    }


    extension(char? seed)
    {
        public IFull Is => seed is null ? ArgumentNull.Throw(err_hint) : ((char)seed).Is;
        public IFull Not => seed is null ? ArgumentNull.Throw(err_hint) : ((char)seed).Not;
        public To.IMenu To => seed is null ? ArgumentNull.Throw(err_hint) : ((char)seed).To;

    }
    private const string err_hint = "No check for null done!";
}
