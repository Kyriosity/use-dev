using ISie.Mk.blocks;

namespace ISie.String.BlankProof;
internal class EncodingWithGap : Fruit_Or<string>, IEncodingWithGapOption
{
    public Encoding Ascii => Next<Encoding>(); // ToDesign: common encoding w/ CHAR !

    public bool Whitespace => Next(string.IsNullOrWhiteSpace);

    public bool SingleSpace => Next(seed => seed is spaces.Single);

    public bool Spaces => Next(seed => seed.ToCharArray().All(ch => ch is ' '));
    public bool Grayspace => Next(NotImplemented.Throw("reserved for further discussions"));
}
