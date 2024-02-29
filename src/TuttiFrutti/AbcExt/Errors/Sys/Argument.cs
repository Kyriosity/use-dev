namespace AbcExt.Errors.Sys;

public class Argument<T> : Shortcuts.Multiargument<ArgumentException>
{
    private Argument() { /* to prevent direct instantiation */ }
}

