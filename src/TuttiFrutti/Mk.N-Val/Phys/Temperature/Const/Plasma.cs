using N_Val.Phys.Temperature;

namespace Mk.N_Val.Phys.Temperature.Const;
public static class Plasma
{
    public static class QuarkGluon
    {
        public static ITemp<long> CERN_2012 => Build.Temperature.Const(5_500_000_000_000, 5_499_999_999_727, 989_9999_999_540);
    }
}
