# T<samp>echniques</samp>&nbsp;&nbsp;&mdash;&nbsp;&nbsp;Wizards/Builders (hard trail)

> ### True **`builders`/`wizards`** beyond chained calls mean far more than coding convenience and mistake-proof input. 

#### As a scripting or meta-language, they must become an alternative design paradigm (not simple patterns).

Only the theoretical overcomplexity of being an uncompromising language feature or library, and the heavy practical overhead of endeavors, made them exotic in our projects.

To compare. Generics are at the pinnacle of **C#** technical embarrassment, while...

<blockquote align="center"><ins>&thinsp;«&thinsp;<b>BUILDERS</b>&thinsp;»&thinsp;</ins> is an <samp>EXPONENTIAL <b>DISASTER</samp></b>&thinsp; in this "sharp" and less strongly-typed object-oriented languages.</blockquote>

<table><tr valign="top"><td width="40%"><picture><img alt="&nbsp;Construction crane collapse" src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/illus/crane_collapse-CA-2024(globalnews.ca).jpg" /></picture></td><td>
<div>We talk about multi-variant branching menus with intuitive context-sensitive options, like:</div>
 <p align="center"><code>_ = UndoRedo.Buffer(3).Depth(5).Zip().Of("start");</code></p>
<div>What's often sold as builders is a counter-intuitive syntax tape of setters and operations,</div>
  <p align="center"><code>_ = Builder.Add(...).Set(...).Add(...).Set(...) ... Make();</code></p>
  <p>which doesn't prevent redundancies, dubious repetitions, and wrong calls.</p>
<p align="center"><b>The challenge is the <ins>combinatorial explosion</ins>.</b></p>
</td></tr></table>

> We are here not to yammer but to collect techniques and ideas that mitigate the complexities and still render intuitive builders (to some extent).

First of all, creating unlimited context constructors is possible with

+ auto-generating templates under defined scenarios,
+ dynamic code generation to stuff the selected interface.

However, are there custom applications for which it wouldn't be a "mega-engineering" and overkill? Let's consider other possibilities:

<table><tr><td><picture><img alt="&nbsp;🚧  W&thinsp;O&thinsp;R&thinsp;K  i&thinsp;n  P&thinsp;R&thinsp;O&thinsp;G&thinsp;R&thinsp;E&thinsp;S&thinsp;S&thinsp; 🐝" src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/_nav/tiles/_WorkInProgress_200px.jpg" /></picture></td><td>
<p>GENERIC PARAMETRIZAION</p>
<p>PARAMETER OBJECT</p>
<p>DYNAMIC FILL OUT</p>
</td></tr></table>

## Theory

|- Builder for side effects\
|- Undo/Redo as a builder

## Realization

Meanwhile, some construction techniques are there:\
|- [<b>Code Wizard blocks</b>](../../../../src/TuttiFrutti/WizConstr/README.md)\
|- [ISie extensions](../../../parts/_ext/ISie/README.md), which rest on these blocks\
|- [AbcChrono](../../../parts/AbcChrono) // is made up of building scripts


The following topics contemplate object building:\
|- [Circuitry](../circuitry)

## Conclusion

Nevertheless, the best technique when hit against the wall is to cut constructors and make other bulky but easy initializations.

\___________\
🔚 ... 2024-2025 .. image credit: https://globalnews.ca (2024)
