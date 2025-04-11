// ReSharper disable InconsistentNaming
using Abc.Logic.Predicate;

namespace AbcExtNUnit.AssertOnAssign;

public abstract class Defined_Errors_Vars : Asserted.Defined_Errors
{
    // Tribute to and mix of FORTRAN and ALGOL68 - https://en.wikipedia.org/wiki/Relational_operator#cite_note-6
    public readonly Dictionary<Mid<TMidKey>, Mid<IEqual>> Eq = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<INotEqual>?> Not = []; // derogation of .NE but better
    public readonly Dictionary<Mid<TMidKey>, Mid<bool>?> Gt = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<bool>?> Lt = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<bool>?> GE = []; // = NOT Lt .......... DO INVERSE FUNCS!
    public readonly Dictionary<Mid<TMidKey>, Mid<int>?> LE = []; // = NOT Gt

    // ToDesign:
    // - Multiple values
    // - Range
    // - Compare
    // - Custom func

    // COUNT Count.EQ[1] = 

    public readonly Dictionary<(double, double), double> Within = [];
    public readonly Dictionary<(double, double), double> Outside = []; // = NOT Within
}

public abstract class TMidKey { }

public class Mid<T>
{
    private static readonly Type _typeOfKey = typeof(TMidKey);
    private static bool _keyed = false;
    private static bool _valued = false;

    private Mid() { }

    public static implicit operator Mid<T>?(double? value) {
        _core++;


        if (_typeOfKey.IsAssignableFrom(typeof(T))) {
            var isKey = true;
        }
        else {
            var IsVal = true;
        }

        if (value is null) {
            var caller = Caller.Report();
        }
        // IF BOTH SET ...
        // ToDo: CHECK if the size of dict grows ! -> CLEAN THE DICT
        return new Mid<T>();

    }

    private static int _core;
}
