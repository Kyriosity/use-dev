namespace Meas.Data.Setup.Attributes;
[AttributeUsage(System.AttributeTargets.Field, AllowMultiple = false)]
public class NotForTestAttribute(string reason = "") : Attribute
{
    public string Reason { get; init; } = reason;
}
