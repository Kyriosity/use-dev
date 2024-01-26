using Abc.Ext.Metadata;

namespace Meas.Units.Metadata;

[AttributeUsage(System.AttributeTargets.Enum, AllowMultiple = false)]
public class ExponentAttribute(int @base) : UtilizedAttribute<ExponentAttribute>
{
    public int Base => @base;
}