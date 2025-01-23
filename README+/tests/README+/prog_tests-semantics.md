# Programmatic tests &mdash; Semantic posers

## Valid syntax but wrong logic

Debunking "silent" logical errors that don't affect success paths is **much more important** than the discovery of explicit errors (<s>users</s> testers will do &mdash; sorry for a dense gag).

### <a id="non-comp-calls">Excluding wrong calls

Most language paradigms (such as casting, access modifiers, and inheritance) and constructs won't allow sophisms (valid code that will throw run-time syntax errors). 

But custom chain calls, and builders are error-prone in exposing repeating or illogical members. The next _NUnit_ call will run but throw the exception:\
&nbsp;&nbsp;&nbsp;&nbsp;<code>Assert.That(1, Is.EqualTo(1).<mark>Within</mark>(1).<mark>Within</mark>(1).<mark>Percent</mark>.<mark>Ulps</mark>)</code>

Consider a contribution to NUnit to prevent such statements.<sup>🙋</sup> Which tests will we attach in the commit?

The only option is to write and comment out statements made non-compatible and comment to uncomment them before a release to ensure they are still invalid (and then comment out again). Preprocessor `#if` directives may help a bit.

Cumbersome?

> A better solution will be a non-trivial metaphysical challenge.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🙋</sup> <sub>That will be another story how many test projects won't build and how many tests (after syntax fix) will fail - those `Expect.Throw<Exception>`.</sub>

\__________\
🔚 🌔 2025 ... 🚧🚧🚧 ... to be continued ... 🚧🚧🚧
