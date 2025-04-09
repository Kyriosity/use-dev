# <samp>Programmatic tests</samp> &nbsp;&nbsp;&mdash;&nbsp;&nbsp; Posers

<h1 align="center">Testing facilities</h1>

## Separating framework and subject errors and bugs

Testbeds and fixtures can throw _things_ intentionally or not. 

Intentionally when wrong conditions are met or misuse occurs &mdash; for such cases, it's obvious to define specific exceptions.

For errors and bugs, you wouldn't write separate test projects but try to make them as sound as possible. Other guidelines are:

+ Max. focus and best practices
+ "Patch" utilities with CATCH


And the worst case: 🚧🚧🚧


<h1 align="center">Syntax</h1>

## Valid syntax but wrong logic

> Debunking "silent" logical errors that don't affect success paths is **much more important** than the discovery of explicit errors (<s>users</s> testers will do &mdash; sorry for a dense gag).

### <a id="non-comp-calls">Excluding wrong calls

Most language paradigms (such as casting, access modifiers, and inheritance) and constructs won't allow sophisms (valid code that will throw run-time syntax errors). 

However, custom chain calls and builders are prone to exposing repeating or illogical members. The next _NUnit_ call will run but throw the exception:\
&nbsp;&nbsp;&nbsp;&nbsp;<code>Assert.That(1, Is.EqualTo(1).<mark>Within</mark>(1).<mark>Within</mark>(1).<mark>Percent</mark>.<mark>Ulps</mark>)</code>

Consider a contribution to NUnit to prevent such statements.<sup>🙋</sup> Which tests will we attach in the commit?

The only option is to write and comment out statements made non-compatible and comment to uncomment them before a release to ensure they are still invalid (and then comment out again). Preprocessor `#if` directives may help a bit.

Cumbersome?

> A better solution will be a non-trivial metaphysical challenge.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🙋</sup> <sub>That will be another story how many test projects won't build and how many tests (after syntax fix) will fail - those `Expect.Throw<Exception>`.</sub>

**P.S. Tip:** `// // real comment` will allow quick manual tests: _Select&nbsp;All_, _Uncomment_, and _Undo_ (<kbd>Ctrl+A</kbd>, <kbd>Ctrl+K+U</kbd>, and <kbd>Ctrl+Z</kbd> in Visual Studio).

\__________\
🔚 🌔 2025 ... 🚧🚧🚧 ... to be continued ... 🚧🚧🚧
