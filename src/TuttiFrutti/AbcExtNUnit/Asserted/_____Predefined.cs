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
        get => ERR_STUB;
        set => Assert.That(value, Is.Not.Null);
    }

    protected static dynamic ERR_STUB =>
        InvalidOperation.Throw($"Getter can't be defined for <{Caller.Report().caller.name}>");

    protected static (string subject, string expected, string digest) Parse(LambdaExpression expression) {
        var subject = expression.Body.ToString()
            .Replace("Invoke(", string.Empty)
            .Replace("Convert(", string.Empty)
            .Replace("value(", string.Empty);

        var index = subject.IndexOf(", ", StringComparison.Ordinal);

        if (-1 < index) {
            subject = subject[..index];

            var closing = subject.IndexOf(").", StringComparison.Ordinal);
            if (-1 < closing) {
                var opening = subject.IndexOf('(');
                if (-1 == opening || opening > closing)
                    subject = subject[(2 + closing)..];
            }
        }
        else {
            index = subject.LastIndexOf(").", StringComparison.Ordinal);
            if (-1 < index)
                subject = subject[(2 + index)..];
        }

        var expected = string.Join(',',
                expression.Parameters.Select(x => x.ToString()));

        return (subject, expected, $"\"{subject}\"=>⚡{expected}⚡: ");
    }

    // Invoke(value(FeatTest.AssertByAssign.AssertOnAssign_Err+<>c__DisplayClass3_0).wrap)
    // FeatTest.AssertByAssign.AssertOnAssign_Err+<>c__DisplayClass3_0).wrap)

    // FUNC:
    // DivideByZeroException => Convert(DivideBy(0), Object)
    // Convert(DivideBy(0), Object)

    // SUB:
    // InvalidOperationException => value(FeatTest.AssertByAssign.AssertOnAssign_Err).InvalidAction(5)
    // value(FeatTest.AssertByAssign.AssertOnAssign_Err).InvalidAction(5)

    // PROP:
    // FieldAccessException => Convert(value(FeatTest.AssertByAssign.AssertOnAssign_Err).Dummy.ErrorGetter, Object)
    // Convert(value(FeatTest.AssertByAssign.AssertOnAssign_Err).Dummy.ErrorGetter, Object)
}

