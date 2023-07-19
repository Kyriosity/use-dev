using System.Numerics;

namespace N_Val;

public interface IFacetValue { }
public interface IFacetValue<N> : IFacetValue where N : INumber<N> { }

