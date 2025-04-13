# Tests🧪 *featuring* ... tests🧪

This project presents _prêt-à-porter_ testing goodies already running in test/demo projects of this solution (Tutti Frutti).

**You are welcome to use them as well.**

<h2 align="center">Attribute shortcuts</h2>

<samp><b>RECOMMENDED:</b><samp> It doesn't introduce new functionality but cleanses existing NUnit calls/references off formalities peel.

-> [Try without further ado](Shortcuts)

<h2 align="center">Variable-like data sources</h2>

Because of C# limitations, NUnit may specify only constants and literals in attributes. 
The boilerplate and verbosity of variable/dynamic (run-time) datasources may be annoying and involve much _Repeat Yourself_.

The alternative in [DataOutsourcing](DataOutsourcing) must be shorter, more explicit, and with some auto-discovery. 

👆 You may extend the technique for less or more specific custom formats, deriving from `IDataSource`, or even implement sophisticated cases like [convert 🧪tests](../FuncStore.Convers.Tests) of 
<sub><picture><img alt="&nbsp;Funcware" src="../../../README+/_rsc/img/symb/funcware/funcware-bar_16px.jpg" title="Conversion functions"/></picture></sub>.


<h2 align="center">Assert-by-assign <a id="assert-by-assign" /></h2>

The intention was not only to shorten syntax but to release the subject of the test from the parentheses (to emphasize).

```csharp
True = yourObject.AnyTruthValuingFunction();
Eq[1968] = CE.YearOf("Algol68");
Within[3.14, 3.15] = CustomPiCalculation();
Error = DivideByZero => MyMath.DivideBy(0.00);
```
-> [More demos](AssertByAssign)

> [!WARNING]
> <samp>EXPERIMENTAL</samp> syntax on questionable premises.
> 
> It's not a replacement of NUnit but some sugar for rapid prototyping and demos.

\___________\
🔚 2025
