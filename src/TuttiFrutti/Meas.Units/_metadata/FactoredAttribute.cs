using Abc.Ext.Metadata;

namespace Meas.Units.Metadata;

[AttributeUsage(System.AttributeTargets.Enum | System.AttributeTargets.Class, AllowMultiple = false)]
public class FactoredAttribute : UtilizedAttribute<FactoredAttribute> { }
