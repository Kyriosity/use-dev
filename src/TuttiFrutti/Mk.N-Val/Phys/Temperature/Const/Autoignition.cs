using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Autoignition
{
    public static ITemp<int> Lead => Build.Temperature.Const.KeCeFa(1_123, 850, 1_562);
    public static ITemp<int> Iron => Build.Temperature.Const.KeCeFa(1_588, 1_315, 2_399);
    public static ITemp<int> WhitePhosphorus => Build.Temperature.Const.KeCeFa(307, 34, 93);
}
