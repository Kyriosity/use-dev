namespace MeasData.Setup.Formats;

public class Subject<N, Unit> where N : INumber<N>
{
    public string Name { get; init; } = string.Empty;

    public string Cat { get; init; } = string.Empty;

    public IEnumerable<(N val, Unit unit)> Entries { get; init; } = Array.Empty<(N val, Unit unit)>();

    public double? Delta { get; init; }
}


public class MeasSubject : Subject<double, string> { }