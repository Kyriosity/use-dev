using Abc.Ext.Metadata;

namespace MeasData.Setup.Metadata;

[AttributeUsage(System.AttributeTargets.Field | System.AttributeTargets.Class | AttributeTargets.Property,
    AllowMultiple = false)]
public class NotForTestAttribute(string reason = "") : UtilizedAttribute<NotForTestAttribute>
{
    public string Reason { get; init; } = reason;
}
