using FuncStore.Convert.RatioScale;
using FuncStore.Convert.Tests.Setup.Steps;
using System.Numerics;
using Cross = Meas.Units.Phys.Distance.Length.Cross;
using Metric = Meas.Units.Prefix.Metric;

namespace FuncStore.Convert.Tests.PhysMath.Dims;

[TestFixture(typeof(Multiplication<Cross.SI_Customary.In>), typeof(Cross.SI_Customary.In))]
[TestFixture(typeof(Multiplication<Metric.In>), typeof(Metric.In))]
[TestFixture(typeof(DecimalExponenting<Metric.Exponent.In>), typeof(Metric.Exponent.In))]

public class LengthsTests<TStore, TUnit> : ArrangeActAssert<TStore, TUnit>
    where TStore : IFuncStore<TUnit>, new() where TUnit : Enum
{
    //[TestCaseSource(typeof(Geo.Elevations))]

    public void ScaleBackForth<N>((N value, string unit) left, (N value, string unit) right, string info) where N : INumber<N> {

        //Assert.Pass($"{'\u25CF'} {'\u26AA'} {'\u26AB'} {'\u272A'}\n" +
        //    $" {'\u274D'} {'\u2B24'} {'\u2B55'} {'\u25D7'} {'\u25E0'} > {'\u25EF'} {'\u2B55'}\n" +
        //    $"⭐ ⭐ {'\u25D2'} {'\u25D0'} {'\u2730'} {'\u2B50'}");

        //var highest = new Geo().Mounts;
        //var mount = highest["Everest"];
        //(double d, string unit) particular = mount[0];

    }
}
