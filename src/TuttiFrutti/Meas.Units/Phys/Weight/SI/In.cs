using Meas.Units.Metadata;

namespace Meas.Units.Phys.Weight.SI;

[Metric]
public enum In //~ implements IFactored, IRatioScaled, IBase10 (i.e. IRatioScaled)
{
    gram = 1,
    kilogram = 1_000,
    centner = 1_000 * 100,

    // megatonne ?
}
