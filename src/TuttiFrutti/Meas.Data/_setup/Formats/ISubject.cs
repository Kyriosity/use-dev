using System.Numerics;

namespace Meas.Data.Setup.Formats;

public class ISubject<N, Unit> where N : INumber<N>
{
    public string Name { get; init; }

    public string Cat { get; init; }

    public IEnumerable<(N val, Unit unit)> Entries { get; init; }

    public double? Delta { get; init; }
}


public class MeasSubject : ISubject<double, string> { }