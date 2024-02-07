using Abc.Ext.Metadata;

namespace MeasUnits.Metadata;

[AttributeUsage(System.AttributeTargets.Enum | System.AttributeTargets.Class, AllowMultiple = false)]
public class FactoredAttribute : UtilizedAttribute<FactoredAttribute> { }
