namespace AbcExtNUnit.Attributes.Case;

public class TestAttribute(params object[] args) : TestCaseAttribute(args);

public class TestIeAttribute<T>(T arg) : TestAttribute() where T : class, new();