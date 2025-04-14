// ReSharper disable InconsistentNaming
using Abc.Logic.Compare;

namespace AbcExtNUnit.AssertOnAssign;

public abstract class Defined_Errors_Vars : Asserted.Defined_Errors
{
    // Tribute to and mix of FORTRAN and ALGOL68 - https://en.wikipedia.org/wiki/Relational_operator#cite_note-6
    public readonly Dictionary<Mid<TMidKey>, Mid<IEqual>> Eq = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<INotEqual>?> Not = []; // derogation of .NE but better
    public readonly Dictionary<Mid<TMidKey>, Mid<IGreater>?> Gt = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<ILesser>?> Lt = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<IGreaterOrEqual>?> GE = []; // = NOT Lt .......... DO INVERSE FUNCS!
    public readonly Dictionary<Mid<TMidKey>, Mid<ILessOrEqual>?> LE = []; // = NOT Gt

    // ToDesign:
    // - Multiple values
    // - Range
    // - Compare
    // - Custom func

    // COUNT Count.EQ[1] = 

    public readonly Dictionary<(double, double), double> Within = [];
    public readonly Dictionary<(double, double), double> Outside = []; // = NOT Within
}

public abstract class TMidKey
{
    internal static readonly Type _type = typeof(TMidKey);

}

public class Mid<T>
{
    private Mid() { }

    public static implicit operator Mid<T>?(double? value) {
        Proc<double?>.Report<T>(value);
        return new Mid<T>();
    }
}

internal class Proc<T>
{
    private static T _expected;
    private static T _right;

    internal static void Report<P>(T value) {


        var env = Caller.Report(2); // ToDo: for debug only
        var typeOfT = typeof(P);

        if (TMidKey._type.IsAssignableFrom(typeOfT)) {
            Semaphore.Keyed = true;
            _expected = value;
        }
        else {
            Semaphore.Valued = true;
            _right = value;
        }

        // ⚠️ this is a draft implementation for demo only
        if (Semaphore.Keyed && Semaphore.Valued) {
            Semaphore.Reset();
            if (typeof(IEqual).IsAssignableFrom(typeOfT))
                if (!_right.Equals(_expected))
                    Assertion.Throw($"{Caller.Report(3).caller.name}: {_right} not equals {_expected}");
                else
                    FixtureError.Throw($"{Caller.Report(2).caller.name}: op still not supported: {typeOfT}");
        }
    }
}

internal static class Semaphore
{
    internal static bool Keyed {
        get; set {
            field = value && field ?
                FixtureError.Throw($"{Caller.Report(3).caller.name}: Repetitive KEY set while VALUE expected")
                : value;
        }
    } = false;

    internal static bool Valued {
        get; set {
            field = value && field ?
                FixtureError.Throw($"{Caller.Report(3).caller.name}: Repetitive VALUE set while KEY expected")
                : value;
        }
    } = false;

    internal static void Reset() {
        Keyed = false; Valued = false;
    }
}