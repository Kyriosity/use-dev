using Mk.N_Val.Phys.Temperature.Build;
using Mk.N_Val.Phys.Temperature.Const;
using N_Val.Phys.Temperature;

namespace N_Val.Test_Learn.Basics;
public class PredefinedProtectionTests
{
    [Test]
    public void TryDowncast() {
        Assert.Throws<InvalidCastException>(() => {
            var unlocked = (ITempEdit<double>)Univ.AbsZero; unlocked.Kelvin = 100;
        });

        var nonsense = Temperature.Const(1, 1, 1);
        Assert.Throws<InvalidCastException>(() => {
            var unlocked = (ITempEdit<double>)nonsense; unlocked.Kelvin = 100;
        });
    }

    [Test]
    public void TryRewrite() {
        var absZero = Univ.AbsZero;

        absZero = Temperature.Kelvin(737.03);
        Assert.That(absZero.Kelvin, Is.Not.Zero);

        var newZero = Univ.AbsZero;
        Assert.That(newZero.Kelvin, Is.Zero);
    }
}
