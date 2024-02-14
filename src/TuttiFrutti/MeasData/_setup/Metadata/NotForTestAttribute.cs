namespace MeasData.Setup.Metadata;

[AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Class | AttributeTargets.Property,
    AllowMultiple = false)]
public class NotForTestAttribute(string reason = "") : ExtendedAttribute<NotForTestAttribute>
{
    public string Reason { get; init; } = reason;
}
