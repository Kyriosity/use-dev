namespace Meas.Units.Metadata;

[AttributeUsage(System.AttributeTargets.Enum, AllowMultiple = false)]
internal class FactoredAttribute : System.Attribute
{
    private int _base;

    public FactoredAttribute(int @base) {
        _base = @base;
    }
}