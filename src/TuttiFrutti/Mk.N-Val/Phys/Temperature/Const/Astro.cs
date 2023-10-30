using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;

public static class Space
{
    public static ITemperature<double> Outer => Build.Temperature.Const.All(2.725, -270.425, -454.765);
}

public static class Earth
{
    public static ITemperature<long> Core => Build.Temperature.Const.All(5_473L, 5_200, 9_392);
}

public static class Sun
{
    public static ITemperature<long> Core => Build.Temperature.Const.All(15_000_273L, 15_000_000, 27_000_000);
}
