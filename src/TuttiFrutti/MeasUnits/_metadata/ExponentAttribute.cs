namespace MeasUnits.Metadata;

[AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
public class ExponentAttribute(int @base) : ExtendedAttribute<ExponentAttribute>
{
    public int Base => @base;
}