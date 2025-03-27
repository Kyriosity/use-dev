using AbcRefl;
// ReSharper disable InconsistentNaming

namespace AbcExtNUnit.Asserted;

public class Predefined
{
    protected virtual bool? False { get => false; set => Assert.That(value, Is.False); }

    protected virtual bool? True { get => true; set => Assert.That(value, Is.False); }


    protected dynamic? Null {
        get => null;
        set => Assert.That(value, Is.Null);
    }

    protected dynamic? NotNull {
        get => CANT_VALUE;
        set => Assert.That(value, Is.Not.Null);
    }

    protected static dynamic CANT_VALUE =>
        InvalidOperation.Throw($"Getter can't be defined for <{Caller.Report().caller.name}>");
}

