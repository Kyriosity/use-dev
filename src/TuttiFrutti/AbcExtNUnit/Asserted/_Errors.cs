namespace AbcExtNUnit.Asserted;
public class Errors : Variable
{
    public virtual Expression<Func<object, object>> Error {
        get => ERR_STUB;
        set => Check(value.Compile(), value);
    }

    public virtual Expression<Action<object>> Err {
        get => ERR_STUB;
        set => Check(_ => { value.Compile()(""); return true; }, value);
    }

    public virtual Expression<Func<object, object>> OkOrError {
        get => ERR_STUB;
        set => Check(value.Compile(), value, true);
    }

    public virtual Expression<Action<object>> OkOrErr {
        get => ERR_STUB;
        set => Check(_ => { value.Compile()(""); return true; }, value, true);
    }

    private static void Check(Func<object, object> method, LambdaExpression expression, bool canSucceed = false) {
        var report = Parse(expression);

        var matches = NormalizeParameters(expression, report.digest);
        var success = false;

        try {
            _ = method("");
            success = true;
        } catch (Exception exception) {
            if (Match.ObjectType<object>(exception, matches) is null) {
                Console.WriteLine($"{report.digest} threw unexpected \"{exception.GetType().FullName}\"");
                throw;
            }
        }
        if (success && !canSucceed)
            Assertion.Throw($"{report.digest} threw no exception at all");
    }

    private static IEnumerable<string> NormalizeParameters(LambdaExpression expression, string callerArg) {
        var parameters = expression.Parameters.Select(x => x.ToString().Trim()).ToList();

        if (parameters.Any(string.IsNullOrWhiteSpace)) // NOTE: don't throw empty / argument exception, which may be expected ...
            TestFixture.Throw($"\"{callerArg}\" submitted whitespace parameters: {parameters.Count(string.IsNullOrWhiteSpace)}"); // ... but testbed specific

        parameters = parameters.Select(x => x.Replace("__", ".")).ToList();
        EnsureExceptionSuffixOption(parameters);

        var duplicates = parameters.GroupBy(x => x).Where(g => g.Count() > 1).ToList();
        if (duplicates.Any())
            TestFixture.Throw($"Duplicated arguments: {string.Join(',', duplicates.Select(y => y.Key).ToList())}");

        return parameters;
    }

    private static void EnsureExceptionSuffixOption(List<string> source) {
        const string option = "Exception";

        var nonSuffixed = source.Where(x => x.Right() != option).ToList();
        source.AddRange(nonSuffixed.Select(x => x + option));
    }
}