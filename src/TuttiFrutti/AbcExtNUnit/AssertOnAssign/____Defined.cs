// ReSharper disable InconsistentNaming

namespace AbcExtNUnit.AssertOnAssign;

public abstract class Defined : Setup
{
    protected const string? NullStr = null;

    public dynamic Empty {
        get => ERR_STUB;
        set => Assert.That(value, Is.Empty);
    }

    public dynamic NotEmpty {
        get => string.Empty;
        set => Assert.That(value, Is.Not.Empty);
    }

    protected virtual bool? False { get => false; set => Assert.That(value, Is.False); }

    protected virtual bool? True { get => true; set => Assert.That(value, Is.True); }


    protected dynamic? Null {
        get => null;
        set => Assert.That(value, Is.Null);
    }

    protected dynamic? NotNull {
        get => ERR_STUB;
        set => Assert.That(value, Is.Not.Null);
    }

    protected double Zero {
        get => 0; set => Assert.That(value, Is.Zero);
    }
    protected double NonZero {
        get => 0; set => Assert.That(value, Is.Not.Zero);
    }
    protected double One { get => 1; set => Assert.That(value, Is.EqualTo(1)); }
}

