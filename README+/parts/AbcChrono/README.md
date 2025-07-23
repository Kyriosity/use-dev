# Chronology &nbsp;&mdash;&nbsp; Timelines &nbsp; &mdash; &nbsp; Events

> <h3>Time is the <i>driver</i> for all and the "solvent" of everything.<br />The former is for software and the latter for its hardware.</h3>

Exact time measurement<sup>🔬</sup> and timestamping aren't an issue for regular solutions but **chronology**.

Software of the previous millennium gave bits for dates (when bits means bits literally), thus nurturing the giant **<samp>Y2K</samp>** bug (and maybe [Y2038](https://en.wikipedia.org/wiki/Year_2038_problem)<sup><b>w</b></sup>).
Contemporary languages can support a vast range of past and future dates<sup>📆</sup>, but badly organize them (not intuitive and error-prone).

&nbsp; &nbsp; <sup>🔬</sup> <samp>Unless you need accuracy close to [physics on steroids](https://www.nobelprize.org/prizes/physics/2023/summary/).<sup>🔗</sup></samp>\
&nbsp; &nbsp; <sup>📆</sup> <samp>C# `DateTime`, astonishingly giving way to Java, supports only the Common Era. Though there are [`Calendar`](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.calendar) classes to rescue.</samp>

## Framework &thinsp;&mdash;&thinsp; Theses

<table><tr valign="top"><td width="60%">
<p align="center"><ins>&nbsp;<b>Overall Wizard diagram</b>&nbsp;</ins></p>
<picture><img alt="&nbsp;Model of Chrono Wizard" src="../../../README+/_rsc/img/Chrono/AbcChrono_GenPic.jpg"></picture><br />
📆 Calendar selection: when applicable and optional<br />
📱 Absolute year calculated from selection (epoch year, century, <i>etc</i>.)<br />
🔄 circa, optional mark to specify delta in the input unit
    </td><td>
 <h3>Initial requirement</h3>
<ul>
<li>Definition of timescales: eras, epochs, or calendars.</li>
<li>Intuitive syntax rooted in Era/Epoch/Calendar specification.</li>
<li>Approximation to specify events known as <b><i>circa</i></b>.</li>
<li>Compile/run-time guards and constraints:<br />range limit (e.g. 1-28/29/30/31 for months) compile- and run-time.</li>
</ul>
       <h3>Next - Features and demands </h3>
<ul>
<li>Fuzzy comparison.</li>
<li>Glossary.</li>
<li>Casting.</li>
<li>More chronologies.</li>
</ul>
<b>The coronation step</b> &mdash; re-making it as a solution of <a href="../MultifacetVal">Multifacet value</a>.
</td></tr></table>

## Implementations

### C#.NET

|- 📖[**AbcChrono**](../../../src/TuttiFrutti/AbcChrono/README.md)\
|--- [Source](../../../src/TuttiFrutti/AbcChrono/)\
|---🧪 [Tests](../../../src/TuttiFrutti/AbcChronoTests/)

🔚 2024-2025
