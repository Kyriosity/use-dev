# Chronology - Timelines - Events

> **Time** is the _driver_ for all and the "solvent" of everything. The former is for software and the latter for its hardware.

Exact time measurement<sup>🔬</sup> and timestamping aren't an issue for regular solutions but chronology.

Software of the previous millennium gave bits for dates (when bits means bits literally), thus nurturing the giant Y2K bug (and maybe [Y2038](https://en.wikipedia.org/wiki/Year_2038_problem))<sup>🔗</sup>.
Contemporary languages can support a vast range of past and future dates<sup>📆</sup>, but badly organize them (not intuitive and error-prone).

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🔬</sup> <sub>Unless you need accuracy close to [physics on steroids](https://www.nobelprize.org/prizes/physics/2023/summary/).<sup>🔗</sup></sub>\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>📆</sup> <sub>C# `DateTime`, astonishingly giving way to Java, supports only Common Era. Though there are [`Calendar`](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.calendar) classes to restraint rescue.</sub>

## Framework - Theses
       
### Initial requirements

+ Definition of timescales: eras, epochs, or calendars
+ Intuitive syntax rooting from Era/Epoch/Calendar specification
+ Approximation to specify events known as _circa_
+ Compile/run-time guards and constraints: range limit (e.g. 1-28/29/30/31 for months) compile- and run-time ()

<details>
  <summary><ins>🖼️&nbsp;<b>Overall Wizard diagram</b>&nbsp;</ins></summary>

  <br/><picture><img alt="Model of Chrono Wizard" src="../../../README+/_rsc/img/Chrono/AbcChrono_GenPic.jpg"></picture>

📆 Calendar selection: when applicable and optional\
📱 Absolute year calculated from selection (epoch year, century, _etc_.)\
🔄 circa, optional mark to specify delta in the input unit

\________________________________

</details>

### Next - Features and demands 

+ Fuzzy comparison
+ Glossary 
+ Casting
+ More chronologies

+ **The coronation step** - re-making it as a solution of [Multifacet value](../U-Val)<sup>👑</sup>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<sup>👑</sup> <sub>Where units of time present values as years are more than natural.</sub>

## Solutions

### C#.NET

|- [**AbcChrono**](../../../src/TuttiFrutti/AbcChrono/README.md)\
|--- [Source](../../../src/TuttiFrutti/AbcChrono/)\
|--- [Tests](../../../src/TuttiFrutti/ExtensionsTests/Chrono/)

🔚
