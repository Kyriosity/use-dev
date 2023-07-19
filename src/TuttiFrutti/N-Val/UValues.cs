using System.Numerics;

namespace N_Val;
[System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:Naming Styles", Justification = "U will be for interfaces of values `U`nits")]
public interface UValues { }
public interface UValues<N> : UValues where N : INumber<N> { }
