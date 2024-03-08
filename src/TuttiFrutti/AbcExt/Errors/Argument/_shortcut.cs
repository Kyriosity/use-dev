using AbcExt.Errors.Shortcuts;

namespace AbcExt.Errors.Argument;

public abstract class Shortcut<TExc>(string message) : ArgumentException(message)
    where TExc : ArgumentException
{
    public static dynamic Throw(string message) => throw Builder.Make<TExc>(message);

    public static dynamic Throw<T>(T subject) => Throw($"{subject}");


}