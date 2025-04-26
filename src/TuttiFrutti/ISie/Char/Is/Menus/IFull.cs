using Abc.Selection;
using ISie.Char.Is.Blocks;

namespace ISie.Char.Is.Menus;

public interface IFull : IDirectCalls,

    ISurrogate<ILowHigh<bool>>,

    IAscii<EncodingOptions>;


