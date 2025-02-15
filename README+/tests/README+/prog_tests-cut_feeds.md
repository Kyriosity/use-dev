# Unit Tests &mdash; Cutting the Feed Expansion

<table align="center"><tr><td><a href=""https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asQA/"><img alt="&nbsp;READ-WRITE meets USE-DEV" width="100px" src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/_nav/read-write_use-dev.jpg" /></a></td><td>
   <p>Let's show how we can meet <a href="https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asQA/README+/tests-damp_vs_dry.md#Feed-expansion"><b>Feed expansion</b></a> with practical decisions.</p>
   <p>(It's theory in the counter repository and here's practice.)</p>
</td></tr></table>

## Dimensional growth

Mostly accepted test frameworks support test methods with a multi-feed of arguments. These are known as data rows, data sources, or meta-attributes and can be of various casting types (e.g., `integer` for `float`) or subclasses.

Alternating functions for _Acts_ can be multi-fed like test data. The same works for external services, test doubles, and miscellaneous settings.

Attributes can be applied to arguments to specify their possible pairing and combinations.

### Defect input

With some tuning, parametrization can supply "defect" data (say, `-4` for integer square root) and expected backlash (as a specific exception to be thrown).

**P.S.** It's not a big deal to write a custom wrapper for missing or improved parameter "funnels".

## Combinatorial explosion

To my knowledge, no popular framework "officially" supports two or more "parallel" feeds (it misses as a concept). For example, test data rows and a list of alternative functions to act on them.

```csharp
/// EXAMPLE PENDING
```

### Workarounding

+ The easiest way is to write cycles. However, this breaks the declarative (markup) style of test specifications. 

+ Frameworks may have _Fixtures_ and _Setups_ which can be hooks to supply extra feed.\
Look as _use-dev_ [funcware tests](../../../src/TuttiFrutti/FuncStore.Convers.Tests/PhysMath) utilize [`TestFixture`](https://docs.nunit.org/articles/nunit/writing-tests/attributes/testfixture.html)<sup><b>NUnit</b></sup> on classes to supply variants of converting functions.

+ And the best solution is to write a framework (or plugin to one) with descriptive multifeed specifications. Who would initiate one? (I would be glad to participate.)

\___________

🔚
