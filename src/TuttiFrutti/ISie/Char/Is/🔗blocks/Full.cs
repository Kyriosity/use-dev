using Abc.Selection;
using ISie.Char.Is.Blocks;

namespace ISie.Char.Is.Menus;
internal class Full : DirectCalls, IFull
{
    public Full(char seed) : base(seed) { }

    public ILowHigh<bool> Surrogate => throw new NotImplementedException();

    public EncodingOptions Ascii => Next<EncodingOptions>(char.IsAscii);
}
