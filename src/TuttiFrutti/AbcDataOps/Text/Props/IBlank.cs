namespace AbcDataOps.Text.Props;

public interface IBlank
{
    bool NullOrEmpty { get; }
    bool NullOrWhitespace { get; }
    bool NullEmptyOrSingleSpace { get; }
    bool NullEmptyOrSpaces { get; }
    bool NullOrGrayspace { get; } // PUNCTUATED !
}

public interface IStrExt_Proofs
{
    //    bool Trimmed(); IDEAS !?

    // All.Ascii() vs. All(predicate);
    // Is.AsciiPrintable<INCL_SPACES)

    // Is.Latin.Symbols
    // Is.Latin.Text / W or wout Blanks grays
    // IsLatin.Basic
}
