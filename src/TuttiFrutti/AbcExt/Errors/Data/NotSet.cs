namespace AbcExt.Errors.Data;

public class NotSet(string message) // Info: to ensure "dynamic" `required`
    : Exception<NotSet>(message);
