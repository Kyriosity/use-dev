namespace ExtensionsTests.Exceptions.Conditional;
public class NArg_MiscDemo
{
    [Test]
    public void ProveIfAny() {
        CheckByIndexes(0, 11, 83, "just test");
        Assert.Throws<ArgumentException>(() => CheckByIndexes(0, -1, 83, "(ensure: index can't be negative)"));

        var primus = 1; var duo = 22.4; byte tres = 100;
        Argument.ThrowIfAny(x => x is < 1 or > 100, primus, duo, tres, 57, 86.21017);

        tres++; var exc = Assert.Throws<ArgumentException>(() =>
            Argument.ThrowIfAny(x => x is < 1 or > 100, primus, duo, tres));
        Assert.That(exc?.Message, Contains.Substring(nameof(tres)));

        var intro = "hello"; var info = "whitespace makes no sense"; var statement = "ditto";
        Argument.ThrowIfAny(string.IsNullOrWhiteSpace, intro, info, statement);

        info = "  "; exc = Assert.Throws<ArgumentException>(() =>
            Argument.ThrowIfAny(string.IsNullOrWhiteSpace, intro, info, statement));
        Assert.That(exc?.Message, Contains.Substring(nameof(info)));
    }

    [Test]
    public void ProveIfTogether() {
        var pA = 0.02; var pB = -12.751; var mC = 70.091; var mDd = 15.772; var measE = -12.02; var measF = 55.0289; var lastM = 124.86;
        ReportMeasurements(pA, pB, mC, mDd, measE, measF, lastM);

        mDd += 1000;
        Assert.Throws<ArgumentException>(() => ReportMeasurements(pA, pB, mC, mDd, measE, measF, lastM));

    }

    // ToDo: INDISTINCT EXC

    private void CheckByIndexes<N>(N arg1, N arg2, N arg3, string message) where N : INumber<N> {
        Predicate<N> isNegativeOrWithFraction = x => x < N.Zero || double.IsInfinity(double.CreateChecked(x));

        Argument.ThrowIfAny(isNegativeOrWithFraction, arg1, arg2, arg3);

    }

    private void ReportMeasurements<N>(N arg1, N arg2, N arg3, N arg4, N arg5, N arg6, N arg7) where N : INumber<N> {
        Predicate<IEnumerable<N>> tooSpread = meas => {
            var minV = meas.Min(); var maxV = meas.Max();
            return N.CreateChecked(1000) < maxV - minV;
        };

        Argument.ThrowIfTogether(tooSpread, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
    }
}
