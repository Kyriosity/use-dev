using ISie.String.Traits;

namespace ISie.Mk.Blocks;
public class Gaps : Fruit_Or<string>, IGaps // ToDesign: common with menu
{
    public bool Whitespace => Next(str => string.IsNullOrWhiteSpace(str.NotNull()) && str is not "");

    public bool SingleSpace => Next(seed => seed is spaces.Single);

    public bool Spaces => Next(seed => seed.ToCharArray().All(ch => ch is ' '));
    public bool Grayspace => Next(NotImplemented.Throw("reserved for further discussions"));
}
