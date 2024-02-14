namespace MeasData.Setup.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.ReturnValue,
    AllowMultiple = false)]
public class PrecisionAttribute(double delta) : ExtendedAttribute<PrecisionAttribute>
{
    public double Delta => delta;
}
