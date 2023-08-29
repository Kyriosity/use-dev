using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;

public static class Space
{
    public static ITemp<double> Outer => Build.Temperature.Const.KeCeFa(2.725, -270.425, -454.765);
}

public static class Earth
{
    public static ITemp<long> Core => Build.Temperature.Const.KeCeFa(5_473L, 5_200, 9_392);
}

public static class Sun
{
    public static ITemp<long> Core => Build.Temperature.Const.KeCeFa(15_000_273L, 15_000_000, 27_000_000);
}
