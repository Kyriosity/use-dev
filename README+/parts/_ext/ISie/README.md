<h1 align="center">⭐&thinsp;I&thinsp;S&thinsp;i&thinsp;e&thinsp;⭐ &nbsp; &mdash; &nbsp; <code>Is.</code><sup>➕</sup> <samp>extensions</samp></h1>

<table align="center"><tr valign="top"><td><picture><img src="../../../_rsc/img/ISie.jpg" alt="&nbsp;&nbsp;I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extensions"/></picture></td><td>
<p><b>The crossover of these two <code>C#</code> discoveries</b></p>
<div>&nbsp; &nbsp; ✔️ &thinsp;legit <a href="../../../frames/README+/calls_on_null.md">calls on null</a>&thinsp;,</div>
<p>&nbsp; &nbsp; ✔️ &thinsp;extension properties <a href="https://github.com/dotnet/roslyn/issues/11159">promised</a>&thinsp;<sup>⏳</sup></p>
<div>suggested me to shortcut ubiquitous </div>
  <div align="center"><code>string.IsNullOrWhiteSpace(<i>abracadabra</i>)</code><br />into<br /><code><i><b>abracadabra</b></i>.IsNullOrWhitespace</code>,<br />
  which finally became<br /><code><i><b>abracadabra</b></i>.Is.NullEmptyOr.Whitespace</code>&thinsp;.</div>
</td><td><picture><img src="../../../_rsc/img/_nav/tiles/ISieCircuitry_200px.jpg" alt="&nbsp;&nbsp;I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extensions"/></picture><br />
  <div align="center"><samp>uses circuitry</samp></div></td></tr></table>

<div align="right"><sup>⏳</sup>&thinsp;<sub>This ever-pending feature must be C#13 "what's new",<br />but finally appeared only as a C#14 preview (April/2025).</sub></div>

This isn't a great new idea to announce unless together with:

+ much more functionality and features (under the theory to port them to other languages),
+ reconsider available `Is`, `To`, ... methods of built-in types.
+ better syntax (to build intuitively and group),
+ extend on other candidate built-in and custom types (obviously _numbers_ and _chars_),
+ render platform for other extensions&nbsp;&nbsp;**<samp>B&thinsp;U&thinsp;T</samp> ...**

<h3 align="center">... let's not beat around the bush and show what's out of the box:</h3>

<table align="center"><tr></tr><tr><td>🧪<b>By guidance</b> (recommended)</td><td>⚡<b>Direct</b> (when you need)</td></tr>
  <tr valign="top"><td>
  <div>Here is the entry point:</div>
  <h2 align="center"><a href="../../../../src/TuttiFrutti/ISie_Tests/BuiltinTypes">D<samp>&thinsp;E&thinsp;M&thinsp;O&thinsp;S</samp>&nbsp;&nbsp;&nbsp;<samp>a&thinsp;n&thinsp;d</samp>&nbsp;&nbsp;&nbsp;T<samp>&thinsp;E&thinsp;S&thinsp;T&thinsp;S</samp></a></h2>
  <p>Optimized for navigation.</p>
  </td><td>
    <div>If you're eager to start without guidance,</div>
  <p>refer <a href="../../../../src/TuttiFrutti/ISie"><code>using ISie</code></a>,</p>
  <p>and let IntelliSense help you!</p>

  </td></tr><tr><td colspan="2" align="center">It's better to explore in Visual Studio or another IDE.</td></tr></table>

## What's next

**IS<samp>IE</samp>** is a subject of expansion (Unicode alone is the encoding [big fish](https://www.unicode.org/glossary/)<sup>🔗</sup>) and a platform for kin features:

+ `.Equal` for strings needs better syntax than the onerous comparison options. 
+ detecting tongues used in text (`Has<Greek>`),
+ _many more_ but which will find its users.

# Appendix. Implementation notes

⭐<b>I&thinsp;S&thinsp;<samp>I&thinsp;E</samp></b>⭐ is a remarkable centerfold for miscellaneous concepts and other parts/features.

## Why `Not`?

If it's just <code>❗subj.Is...</code>. &rArr; **Visibility** &thinsp;&mdash;&thinsp; surrounding symbols may shade subtle `!`, and **C#** itself offers `is not`. 

It's up to you which lexis to pick in **each** case.

<table><tr><td align="center"><b>algebraic language</b></td><td align="center"><b>perceptible tongue</b></td></tr><tr><td>
<p><code>if(<mark><b>!</b></mark>longStringVarName.Is.NullOr.Empty())</code></p>
<p><code>x => <mark><b>!</b></mark>x.Is.EmptyOr.Whitespace()</code></td></p>
<td>
<p><code>if(longStringVarName.<b>Not</b>.NullOr.Empty())</code></p>
<p><code>x => x.<b>Not</b>.EmptyOr.Whitespace()</code></p>
</td></tr></table>

### Beyond syntax alternative

This qualifier reserves the place for other possibilities, say, `All()...`, `Can()...`, `None.Ascii...`, `No.Symbols...`  

With ⭐ISie⭐, it will be easy to enhance available menus, define new modules, or cover custom types.

## Spin-Offs

⭐ISie⭐ was referred in [TDD watershed](https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asDrive/README+/TDD-Watershed/README.md#TDD-ISie).

This feature launched 

+ 🗣️&thinsp;tongues categorization in [Abc Lingua](../../../../src/TuttiFrutti/AbcLingua),
+ 🪫&thinsp;[Circuitry](../../../techniques/README+/circuitry) (as a pattern via techniques),
+ 🏗️&thinsp;[Code wizards](../../../../src/TuttiFrutti/WizConstr/README.md),
+ 🧪&thinsp;[Assert shortcuted to assign](../../../../src/TuttiFrutti/FeatTest/AssertByAssign)

\___________\
🔚 .. <samp>🐝🐝 <code>OR</code> ❗too 🐝</samp> ... 🌘 **2025** ... <sub>[![C#](https://custom-icon-badges.demolab.com/badge/C%23-but_for_all-orangered.svg?logo=cshrp&logoColor=white&color=turquose)](#)</sub>
