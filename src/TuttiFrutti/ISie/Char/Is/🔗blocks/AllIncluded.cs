using ISie.Char.Is.Blocks;

namespace ISie.Char.Is.Menus;
internal class AllIncluded<IO>(char seed) : DirectCalls<IO>(seed), IFull
    where IO : Circuitry.IO
{
    public Surrogates Surrogate => Next<Surrogates>(char.IsSurrogate);

    public EncodingOptions Ascii => Next<EncodingOptions>(char.IsAscii);
}
