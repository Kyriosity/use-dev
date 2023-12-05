using Abc.Ext.Errors.Sys;
using Meas.Units.Phys.Temperature;
using System.Numerics;

namespace UVal.Test_Learn;

public class BuildWaysTest
{
    [Test]
    public void DIRECT() {
        var C = In.Celsius;
        var K = In.Kelvin;

        var waterTemp = UVal.Of(170.53, In.Celsius);
        var tmprt = waterTemp[C];
        waterTemp[K] = 1;

        var pc = UVal.Of(444, Meas.Units.Fin.Currency.In.EUR, new VisaExchange<Meas.Units.Fin.Currency.In>());
        // ToDo: add hard currencies fixed at the end

        var newT = UVal.Const.Of(1, K);

        var tested = newT[C];
    }

    [Test]
    public void CustomFabricFixedType() {
        // PARAM !
    }

    [Test]
    public void CustomFabricLooseType() {

        var temperature = new UVal<In>();
        temperature.Of(1.11);
    }

    [Test]
    public void Predefined() {
        // Temperature.Celsius
    }

    class VisaExchange<U> : ICurrencyExchange<U> where U : Enum, IConvertible
    {
        public Func<N, N> For<N>(U from, U to) where N : INumber<N> => NotImplemented.Throw();
    }

    class EuroCentralBankExchange<U> : ICurrencyExchange<U> where U : Enum, IConvertible
    {
        public Func<N, N> For<N>(U from, U to) where N : INumber<N> => NotImplemented.Throw();
    }

    interface ICurrencyExchange<U> : IFuncStore<U>, IMathOpsEnabled where U : Enum, IConvertible { }
}
