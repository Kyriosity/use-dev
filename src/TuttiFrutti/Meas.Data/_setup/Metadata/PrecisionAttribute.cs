using Abc.Ext.Metadata;

namespace Meas.Data.Setup.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.ReturnValue,
    AllowMultiple = false)]
public class PrecisionAttribute(double delta) : UtilizedAttribute<PrecisionAttribute>
{
    public double Delta => delta;
}
