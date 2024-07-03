# Chronology - Timelines - Events

Time is the _driver_ for all and the "solvent" of everything. The former is for software and the latter for its hardware.

Exact time measurement<sup>🔬</sup> and timestamping aren't an issue for regular solutions but chronology.

Software of the previous millennium gave bits for dates (when bits means literally bits), thus nurturing the giant Y2K bug. 
Contemporary languages can support a vast range of past and future dates<sup>📆</sup>, but badly organize them (not intuitive, error-prone).

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🔬</sup> <sub>Unless you need accuracy close to [physics on steroids](https://www.nobelprize.org/prizes/physics/2023/summary/).<sup>🔗</sup></sub>\
&nbsp;&nbsp;&nbsp;&nbsp;<sup>📆</sup> <sub>Astonishly surrending to Java  C# `DateTime`supports only Common Era. Though there are [Calendar](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.calendar)<sup>🔗</sup> classes to limited rescue.</sub>

## Framework - Theses
       
### Initial requirements

+ Definition of timescales: eras, epochs, or calendars
+ Intuitive syntax rooting from Era/Epoch/Calendar specification
+ Approximation to specify events known as _circa_
+ Compile/run-time guards and constraints: range limit (e.g. 1-28/29/30/31 for months) compile- and run-time ()

<details>
  <summary><ins>&nbsp;<b>Overall Wizard diagram</b>&nbsp;</ins></summary>

  <br/> <picture><img alt="Model of Chrono Wizard" src="../../../README+/_rsc/images/Chrono/AbcChrono_GenPic.jpg"></picture>

📆 Calendar selection: when applicable and optional\
📱 Absolute year calculated from selection (epoch year, century etc.)\
🔄 circa: optional mark to specify delta in the input unit

---

</details>

### Next - Features and demands 

+ Fuzzy comparison
+ Glossary 
+ Casting
+ More chronologies

### The crown - Integration with U-Val

## Solutions

INTRO PENDING!

|- [C# AbcChrono](../../../src/TuttiFrutti/AbcChrono)\
|--- Source\
|--- Tests

