using System.Numerics;

namespace Meas.Data.Setup.Formats;

public readonly struct ISubject<N, Unit> where N : INumber<N>
{
    public string Name { get; init; }

    public string Cat { get; init; }

    public IEnumerable<(N, Unit)> Entries { get; init; }

    public IDictionary<string, object> Attributes { get; init; }

}
