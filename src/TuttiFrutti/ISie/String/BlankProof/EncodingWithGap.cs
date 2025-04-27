using ISie.Mk.blocks;

namespace ISie.String.BlankProof;
internal class EncodingWithGap : Fruit_Or<string>, IEncodingWithGapOption
{
    public Encoding Ascii => Next<Encoding>(); // ToDesign: common encoding w/ CHAR !

    public bool Whitespace => Next(Is.Whitespace);

    public bool SingleSpace => Next(str => str is spaces.Single);

    public bool Spaces => Next(Is.Spaces);
    public bool Grayspace => Next(Is.Grayspace);
}
