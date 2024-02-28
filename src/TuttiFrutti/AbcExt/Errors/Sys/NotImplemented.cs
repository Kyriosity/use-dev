namespace AbcExt.Errors.Sys;
public class NotImplemented : Shortcuts.Direct<NotImplementedException>
{
    public static dynamic Throw(params object?[] dummiesToRemoveWarningsInCaller) => throw new NotImplementedException();
}

