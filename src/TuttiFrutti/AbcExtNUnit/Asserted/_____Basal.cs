// ReSharper disable InconsistentNaming

namespace AbcExtNUnit.Asserted;

public abstract class Basal
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

}

