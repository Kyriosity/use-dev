namespace AbcExtNUnit.Exceptions;

public class TestFixture(string message)
    : AbcCommu.Errors.Basal.Exception<TestFixture>(message);
