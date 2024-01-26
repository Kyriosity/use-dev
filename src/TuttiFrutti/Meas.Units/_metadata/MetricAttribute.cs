using Abc.Ext.Metadata;

namespace Meas.Units.Metadata;

[AttributeUsage(System.AttributeTargets.Enum, AllowMultiple = false)]
internal class MetricAttribute : UtilizedAttribute<MetricAttribute> { }
