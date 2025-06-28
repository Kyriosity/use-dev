using Abc.Logic.Compare;

namespace AbcExtNUnit.AssertOnAssign.setup;
internal class Proc<T>
{
    private static T _expected;
    private static T _right;

    internal static void Report<P>(T value) {
        var typeOfT = typeof(P);

        if (TMidKey._type.IsAssignableFrom(typeOfT)) {
            Semaphore.Keyed = true;
            _expected = value;
        }
        else {
            Semaphore.Valued = true;
            _right = value;
        }
        // ⚠️ 
        // This is a dirty draft implementation for demo only
        // ⚒️ The subject of developing as Task with "circuitry"
        // https://github.com/Kyriosity/use-dev/blob/main/README+/techniques/README+/circuitry/README.md
        // when - passing test project found.
        // ⚠️ 
        if (Semaphore.Keyed && Semaphore.Valued) {
            Semaphore.Reset();
            if (typeof(IEqual).IsAssignableFrom(typeOfT)) {
                if (!_right.Equals(_expected))
                    Assertion.Throw($"{Caller.Digest}: {_right} not equals {_expected}");
            }
            else if (typeof(INotEqual).IsAssignableFrom(typeOfT)) {
                if (_right.Equals(_expected))
                    Assertion.Throw($"{Caller.Digest}: {_right} not equals {_expected}");
            }
            else
                FixtureError.Throw($"{Caller.Digest}: op still not supported: {typeOfT}");
        }
    }
}

internal static class Semaphore
{
    internal static bool Keyed {
        get; set {
            field = value && field ?
                FixtureError.Throw($"{Caller.Digest}: Repetitive KEY set while VALUE expected")
                : value;
        }
    } = false;

    internal static bool Valued {
        get; set {
            field = value && field ?
                FixtureError.Throw($"{Caller.Digest}: Repetitive VALUE set while KEY expected")
                : value;
        }
    } = false;

    internal static void Reset() {
        Keyed = false; Valued = false;
    }
}
