using ISie.Char.Is.Blocks;

namespace ISie.Char.Is.Menus;
internal class AllInclusive : DirectCalls, IFull
{
    public AllInclusive(char seed) : base(seed) { }

    public Surrogates Surrogate => Next<Surrogates>(char.IsSurrogate);

    public EncodingOptions Ascii => Next<EncodingOptions>(char.IsAscii);
}
