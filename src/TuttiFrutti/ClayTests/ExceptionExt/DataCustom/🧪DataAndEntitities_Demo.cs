namespace ClayTests.ExceptionExt.DataCustom;
public class DataAndEntitities_Demo
{
    [Test]
    public void RequiredProps() {
        var dummy = new Dummy { Info = "Required fields can be set ASAP but ...", Token = 1 };
        Assert.That(dummy.Token, Is.EqualTo(1));

        dummy = new() { Info = "... what if not, e.g. in builders" };

        Assert.Throws<NotSet>(() => _ = dummy.Token);
        Assert.Throws<NotSet>(() => _ = dummy.Token, "retry to get hasn't failed");

        dummy.Token = 7;
        Assert.That(dummy.Token, Is.EqualTo(7));
    }

    [Test]
    public void StubbedProperty_Bizzare() { /// ToDo: NotSet ? UnSET ?
        var dummy = new Dummy() { Info = "NotSet" };

        Assert.Throws<NotSet>(() => _ = dummy.NotReleased);
    }

    [Test]
    public void Method_NotRecommended() {
        var dummy = new Dummy() { Info = "NotSet" };
        Assert.Throws<NotSet>(() => dummy.EncryptToken(subj => -Math.PI * subj / 2));

        dummy.Token = 7;
        Assert.That(dummy.EncryptToken(subj => -Math.PI * subj / 2), Is.Negative);
    }

    private class Dummy
    {
        internal double EncryptToken(Func<ushort, double> func) => _token is null ? NotSet.Throw() : func((ushort)_token);

        internal required string Info { get; set; }

        internal ushort Token { get => _token ?? NotSet.Throw(); set => _token = value; }

        private ushort? _token;

        public bool NotReleased => NotSet.Throw($"No data for \"{nameof(NotReleased)}\" will be available in this release");
    }
}
