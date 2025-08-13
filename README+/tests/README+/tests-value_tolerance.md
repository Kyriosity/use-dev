# Software Tests &nbsp;&mdash;&nbsp; Loose Assert &nbsp;&mdash;&nbsp; Value Tolerance

> This concept interlaces with [gradual assert](unit_test-gradual_assert.md). Both features complement each other.

Known test frameworks support deltas for comparing numbers to expected values, like [`Within`](https://docs.nunit.org/articles/nunit/writing-tests/constraints/EqualConstraint.html)<sup><b>NUnit</b></sup>.
Aside from absolute values, these asserts may specify percent, [ULP](https://en.wikipedia.org/wiki/Unit_in_the_last_place)<sup><b>w</b></sup> or time units.

However, deltas may differ for the `+/—` sides of deltas, similar to _engineering fit_. You may also want to specify more elaborate conditions. Covering with a custom function is easy and fast (or even extending the _Assert_) and doesn't merit special attention. 

The challenge is creating cascading attributes for test data, classes, and cases to mark(up) predefined tolerance functions. 
Current implementation supplies only absolute [[Precision]](../../../src/TuttiFrutti/MeasData/Mech/Force/Thrusts.cs) but shall be expanded to markup like:

`[Precision[+0.05, -1%]]`

// ... 🚧 TO IMPLEMENT ...

\__________\
🔚 2024-2025 ... 🚧 pending 🚧 ...
