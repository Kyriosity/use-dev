namespace Abc.Accuracy;
public interface IConfidence<N> where N : INumber<N>
{
    N Interval { get; }
}


public interface IConfidence_Init<N> : IConfidence<N>
    where N : INumber<N>
{
    new N Interval { get; init; }
}

public interface IConfidence_Edit<N> : IConfidence<N>
    where N : INumber<N>
{
    new N Interval { get; set; }
}

