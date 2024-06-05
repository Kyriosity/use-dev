using System.Data.SqlTypes;

namespace AbcExt.Errors.Sys;
public class NotImplemented : AbcException<NotImplementedException>
{
    private NotImplemented() { /* to prevent direct instantiation */ }

    public static dynamic ToDo(string message) => true;
    public static T ToDo<T>(string message) where T : INullable => ToDo<T>(default, message);
    public static T ToDo<T>(T stub, string message) => stub;
}

