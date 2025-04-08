namespace AbcExtNUnit.Asserted;

public abstract class plusNumbers : plusErrors
{
    protected double Zero {
        get => 0; set => Assert.That(value, Is.Zero);
    }
    protected double NonZero {
        get => 0; set => Assert.That(value, Is.Not.Zero);
    }

    protected double One { get => 1; set => Assert.That(value, Is.EqualTo(1)); }

    //    Num.PRIMARY
}
