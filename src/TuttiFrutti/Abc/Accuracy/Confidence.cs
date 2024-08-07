﻿namespace Abc.Accuracy;
public class Confidence<N> : IConfidence_Init<N> where N : INumber<N>
{
    public virtual N Delta { get; init; } = N.Zero;
}

public class Confidence_Edit<N> : IConfidence_Edit<N> where N : INumber<N>
{
    public virtual N Delta { get; set; } = N.Zero;
}

public class Confidence : Confidence<byte>;
public class Confidence_Edit : Confidence_Edit<byte>;
