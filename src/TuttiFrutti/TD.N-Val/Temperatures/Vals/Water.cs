namespace TestData.N_Val.Temperatures.Vals;

[Obsolete]
public static class Water
{
    public static readonly (float K, float C, float F, float delta) Boiling = (373.15F, 100.0F, 212.00F, 0.00005F);
    public static readonly (decimal K, decimal C, decimal F, decimal delta) TriplePoint = (273.16M, C: 0.01M, F: 32.018M, delta: 0.001M);
}
