namespace AbcRefl.Metadata.Ratio;

[AttributeUsage(AttributeTargets.Enum, AllowMultiple = false)]
public class ExponentAttribute(int @base) : ExtendedAttribute<ExponentAttribute>
{
    public int Base => @base;
}
