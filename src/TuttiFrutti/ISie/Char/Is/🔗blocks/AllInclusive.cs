using ISie.Char.Is.Blocks;

namespace ISie.Char.Is.Menus;
internal class AllInclusive(char seed) : DirectCalls(seed), IFull
{
    public Surrogates Surrogate => Next<Surrogates>(char.IsSurrogate);

    public EncodingOptions Ascii => Next<EncodingOptions>(char.IsAscii);
}
