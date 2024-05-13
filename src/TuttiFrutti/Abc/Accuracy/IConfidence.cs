namespace Abc.Accuracy;
public interface IConfidence<N> where N : INumber<N>
{
    N Delta { get; }
}


public interface IConfidence_Init<N> : IConfidence<N>
    where N : INumber<N>
{
    new N Delta { get; init; }
}

public interface IConfidence_Edit<N> : IConfidence<N>
    where N : INumber<N>
{
    new N Delta { get; set; }
}

