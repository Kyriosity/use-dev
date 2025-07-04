using AbcStoppers.Guards;

namespace ExtensionsTests.Guards;

public class StringGuards : AbcExtNUnit.AssertOnAssign.Defined_Errors_Vars
{
    [SyntaxDemo]
    public void Blanks() {
        const string sample = "sample";
        True = sample == sample.NoEmpty;
        False = $"{sample}2" == sample.NoEmpty.NoNull;
        //Error = EmptyException => "".NoEmpty; ENABLE after .NET update

        _ = "".NoNull.NoWhite;
        //Error = ArgumentException => "  ".NoEmpty;
    }
}