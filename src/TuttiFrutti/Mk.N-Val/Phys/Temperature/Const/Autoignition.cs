using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Autoignition
{
    public static ITemperature<int> Lead => Build.Temperature.Const.All(1_123, 850, 1_562);
    public static ITemperature<int> Iron => Build.Temperature.Const.All(1_588, 1_315, 2_399);
    public static ITemperature<int> WhitePhosphorus => Build.Temperature.Const.All(307, 34, 93);
}
