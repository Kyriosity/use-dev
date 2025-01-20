<h1 align="center">⭐&thinsp;I&thinsp;S&thinsp;i&thinsp;e&thinsp;⭐ &rarr; <code>.Is</code> / <code><samp>.Not</samp></code> <samp>extensions</samp></h1>

<table><tr valign="top"><td><picture><img width="250px" src="../../../_rsc/img/ISie.jpg" alt="&nbsp;&nbsp;I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extensions"/></picture></td><td>
<p><b>The crossover of these two <code>C#</code> discoveries</b></p>
<div>&nbsp;&nbsp;&nbsp;&nbsp;✔️&thinsp;legit <a href="../../../frames/README+/calls_on_null.md">calls on null</a>,</div>
<p>&nbsp;&nbsp;&nbsp;&nbsp;✔️&thinsp;extension properties <a href="https://github.com/dotnet/roslyn/issues/11159">promised</a></p>
<div>suggested me to shortcut ubiquitous <code>string.IsNullOrWhiteSpace(<i>abracadabra</i>)</code> into <code><i><b>abracadabra</b></i>.IsNullOrWhitespace</code>.</div>
</td><td><picture><img width="250px" src="../../../_rsc/img/_nav/tiles/ISieCircuitry_200px.jpg" alt="&nbsp;&nbsp;I&thinsp;S&thinsp;i&thinsp;e&nbsp;&nbsp;extensions"/></picture></td></tr></table>

This isn't a great new idea and won't be announced unless we ship it together with:

+ much more functionality and features (under the theory to port them to other languages),
+ better syntax (to build intuitively and group),
+ extend on other candidate types (such as obvious _numbers_ and _chars_),
+ make platform for other extensions&nbsp;&nbsp;**<samp>B&thinsp;U&thinsp;T</samp> ...**

<h3 align="center">... let's not beat around the bush and show what's delivered:</h3>

<table align="center"><tr></tr><tr><td>⚡<b>Fast</b> (not recommended)</td><td>🧪<b>By guidance</b> (recommended)</td></tr>
  <tr valign="top"><td>
  <div>If you're eager to start without guidance,</div>
  <p>refer <a href="../../../../src/TuttiFrutti/AbcDataOps/ISie"><code>using AbcDataOps.ISie</code></a>,</p>
  <p>and let IntelliSense help you!</p>
</td><td>
  <div>Here is the entry point:</div>
  <p><a href="../../../../src/TuttiFrutti/AbcShortcutsTests/ISie">Demos and tests</a>.</p>
  <p>It's optimized for navigation.</p>
</td></tr></table>

## Implementation notes

ISie is remarkable as a short feature condensing many ideas and techniques (at least compared to others of mine).

### Props lost «in active development»<sup>📨</sup>. Or Blessing in disguise

<p align="right"><sup>📨</sup> <sub>"The official status" still in 2025</sub></p>

I delayed ISie up to C#13, and when it didn't come decided to BREAKINGLY replace extension methods. However .... 

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🙋</sup> <sub>Even in 2025 - warm greeting to bloggers who advertised it as C#13 "what's new"). We'll use methods and once remove `()` &mdash; uh, breaking change.</sub> 
Extension properties appeared to be "<samp>still in active design</samp>"<sup>🙋</sup> but this didn't stop me from thinking about developing this shortcut into something weightier:

### Why `Not()`?

If it's just <code>❗subj.Is()...</code>. Visibility - surrounding symbols may "hide" `!`. **C#** alone offers the `not` alternative and it's up to you what lexics to select.

#### Beyond syntax alternative

This qualifier reserves the place for other possible, say, `All()...`, `Can()...`, `None.Ascii...`, `No.Symbols...`  

### TDD ISie

As [example](https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asDrive/README+/TDD-Watershed/README.md#TDD-ISie) in TDD Watershed

Source code:

### Cross-projects

AbcLingua

This project initiated [circuitry](../../../techniques/README+/circuitry).

This feature contributes to [builders](../../../techniques/README+/builders).

## Wrap up. What's next

This first release is stable but very experimental.

Equal - is burdensome with options

+ extensibility: you may both arrange your syntax over ISie and add new staff (like tongues) and FEATURES (like Is() on your custom types).

UNICODE - BIG TOPIC https://www.unicode.org/glossary/#ASCII

Decypher of languages

\___________\
🔚 .. <samp>🐝🐝 <code>OR</code> ❗too 🐝</samp> ... 🌘 **2025** ... <sub>[![C#](https://custom-icon-badges.demolab.com/badge/C%23-but_for_all-orangered.svg?logo=cshrp&logoColor=white&color=turquose)](#)</sub>
