using AbcExtNUnit.Attributes.Source.Defined;

namespace FeatTest.DataOutsourcing;

public class DeclaredSource
{
    [Test<Whitespaces, Whitespaces.Char, Whitespaces.Mix>]
    public void FromConstants(object datasource, object key, object val) {
        Assert.That($"{val}".Is.NullEmptyOr.Whitespace, Is.True, $"{datasource}>{key}: NOT proven as whitespace");
    }
}