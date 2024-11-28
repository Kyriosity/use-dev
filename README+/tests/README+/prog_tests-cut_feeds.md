# Tests &mdash; Cutting the Feed Expansion

<table><tr><td><img alt="&nbsp;READ-WRITE meets USE-DEV" width="100px" src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/_nav/read-write_use-dev.jpg" /></td><td>
   <p>Let's show how we could meet <a href="https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asQA/README+/tests-damp_vs_dry.md#Feed-expansion"><b>Feed expansion</b></a> with practical decisions.</p>
   <p>(It's theory and here's practice.)</p>
</td></tr></table>

## Dimensional growth

Mostly accepted test frameworks support test methods with a multi-feed of arguments. They are known as data rows, data sources, or meta-attributes and can be of various casting types (as `integer` for `float`) or subclasses.

Alternating functions for _Acts_ can be multi-fed the same way as test data. The same works for external services, test doubles, and miscellaneous settings.

Attributes can be applied to arguments to specify their possible pairing and combinations.

### Defect input

With some tuning, parametrization can supply "defect" data (say, `-4` for integer square root) and expected backlash (as a specific exception to be thrown).

**P.S.** It's not a big deal to write a custom wrapper for missing or improved parameter "funnels".

## Combinatorial explosion

To my knowledge, no popular framework supports two or more parallel feeds. For example, test data rows along with alternative functions to act on them.

```csharp
/// EXAMPLE PENDING
```
### Workarounding

The easiest way is to organize cycles. However, this breaks the declarative (markup) fashion of the tests. 

An [example test](../../../src/TuttiFrutti/FuncStore.Convers.Tests/PhysMath/Dims/LengthsTests.cs) with two feeds

\___________

🔚
