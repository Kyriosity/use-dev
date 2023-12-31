using System.Numerics;

namespace Meas.Data.Formats;

public readonly struct ISubject<N, TUnit> where N : INumber<N>
{
    public string Name { get; init; }

    public string Cat { get; init; }

    public IEnumerable<(N, TUnit)> Entries { get; init; }

    public IDictionary<string, string> Attributes { get; init; }

}
