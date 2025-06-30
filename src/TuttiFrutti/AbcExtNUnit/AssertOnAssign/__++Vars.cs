// ReSharper disable InconsistentNaming
using Abc.Logic.Compare;
using AbcExtNUnit.AssertOnAssign.setup;

namespace AbcExtNUnit.AssertOnAssign;

public abstract class Defined_Errors_Vars : Defined_Errors
{
    // Tribute to and mix of FORTRAN and ALGOL68 - https://en.wikipedia.org/wiki/Relational_operator#cite_note-6
    public readonly Dictionary<Mid<TMidKey>?, Mid<IEqual>> Eq = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<INotEqual>?> Not = []; // derogation of ".NE" but better
    public readonly Dictionary<Mid<TMidKey>, Mid<IGreater>?> Gt = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<ILesser>?> Lt = [];
    public readonly Dictionary<Mid<TMidKey>, Mid<IGreaterOrEqual>?> GE = []; // = NOT Lt .. DO INVERSE FUNCS!
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