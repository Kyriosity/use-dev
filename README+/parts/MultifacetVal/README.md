# Multifaceted Value 💠 (**Π-Val**) 

<p dir="rtl">?Gauges&nbsp;-<br />!<b>300</b>&nbsp;-<br />
?What 300&nbsp;-<br />?What gauges&nbsp;-</p>

 You may find the folklore right above dull but not pointless.&nbsp;&mdash; Math deals with <mark>abstract numbers</mark> (_numerus numerans_), computers operate on pure digits but not software developers and users.
 The "inputs" and "outputs" of software anchor to the material world, where numbers can be <mark>concrete</mark> (_numerus numeratus_) or <mark>denominated</mark> (_numerus denominatus_).
 
Verbal, documented, and, **programmatic** communications frequently rely on titles and contexts and omit denominations/units. Shall a context wane - values may "roam" between measurement systems:
<details><summary>&nbsp;<ins>&nbsp; Temperature <code>2.7</code> is&thinsp;</ins><b> .&nbsp;.&nbsp;.</b></summary>
... <ins>the baseline of outer space in <i>Kelvin</i></ins> but in earthly <i>Celsius</i> or <i>Fahrenheit</i> a normal winter forecast (placewhere on 40° or higher latitude) .
<br /><br />
            
- A close approach of Earth to Mars is ca. `33'900'000` _miles_ but seems credible in _kilometers_ and _nmi_.
- An unknown child's age of 7` can mean months and years.
- _`Jack`_ can be family, given (not only on birth), and branded name.
- One apple may mean an electronic device too,
- The weekly payment of `1'000` dollars has a national hue: Australian, Canadian, Jamaican, and twenty more. 

Concurrent measurement systems can make matters even worse, e.g. flight height can be communicated in <i>feet</i> while cockpit variometers may show <i>meters</i>.

\____________________________________________________________________________________________________ </details>

Not _denominated_ numbers in applications may imply a single system of categorization (e.g. **SI** for physical values) and ... open wide the gate to errors, including ill-famed techno-disasters.<sup>🔄️</sup>

Coding like `const OuterSpace_Baseline_Kelvin = 2.7` is univocal but inflexible and ugly to the object-oriented eye. As picky pros, we'd propose trailblazing syntax and features.

### <code><<samp>BAIT</samp><sub>🪝</sub>></code> Mars Orbiter, or "The Empire [unit] Strikes Back"

<details><summary><ins>&nbsp;<i>Pound-force</i> [lbf] taken for <i>Newton</i> [N] destroyed the NASA Mars Climate Observer in 1999.&nbsp;</ins></summary>
&nbsp;
 
NASA part of the software relied on metric data from the "contractor" (the report doesn't name the known company and neither do I). Still, the latter sent thrust in the _US Customary units_, based on the good old British **Imperial Pound**. Thus the poor
[Mars Climate Orbiter](https://en.wikipedia.org/wiki/Mars_Climate_Orbiter)<sup><b>w</b></sup> was put below the "survival altitude" orbit. 

```mermaid
sequenceDiagram
participant NAV as Navigation Sofware<br />(Ground)
participant SF as Small Forces<br />Software (Ground)
participant SFO as Small Forces<br />Software (Spacecraft)
participant MCO as Mars Climate<br />Orbiter
participant M as Mars<br />(Planet)
       MCO->>SFO: angular momentum!!
      SFO->>MCO: command: thrust to de-spun
      SFO->>SF: AMD with thrust in pound
      SF->>SF: calculate the position (attitude and orientation)
Note over SF,SF: done right since operates in pounds
      SF->>NAV: thrust data
rect rgb(255, 175, 175)
      NAV->>NAV: recalculate trajectory
Note over NAV,NAV: pound-second taken as newton-second 
end
      NAV->>MCO: Trajectory Correction Maneuver
      MCO--)M: approaches
Note over MCO,M: below the estimated trajectory
      M--xMCO: destroys
Note over M,MCO: atmospheric stress
destroy participant MCO
```
<div dir="rtl"><sub>Source: <a href="https://sma.nasa.gov/docs/default-source/safety-messages/safetymessage-2009-08-01-themarsclimateorbitermishap.pdf?sfvrsn=eaa1ef8_4">NASA: Lost in Translation, 2009</a></sub></div>

\____________________________________________________________________________________________________ </details>

Our framework could save astronomical bucks:

```diff

class Thrust : EventArgs
{
-   double Magnitude;
+   UVal.Phys.Mech.Force Magnitude;
    vector Direction;
    milliseconds Duration;
}

namespace CONTRACTOR.SmallForecesTeam;

event EventHandler<ThrustArgs> AngularMomentumDesaturation;

AngularMomentumDesaturation.Invoke(new Thrust {
-  Magnitude = reported_val,
+  Magnitude = Force.pound(reported_val),
   Direction = reported_dir, Duraion = duration
});

namespace NASA.Orbiter.NavigationTeam;

OnForce(Thrust thrust) {
-   Trajectory.Apply(thrust.Magnitude, thrust.Vector, thrust.Duration);
+   Trajectory.Apply(thrust.Magnitude.newton, thrust.Vector, thrust.Duration);
...
}

```

Conversion here is trivial, and <sub><picture><img alt="&nbsp;f&thinsp;u&thinsp;n&thinsp;c&thinsp;w&thinsp;a&thinsp;r&thinsp;e&thinsp;" src="../../_rsc/img/symb/funcware/funcware-bar_16px.jpg" /></picture></sub> offers an implementation [you can test🧪](../../../src/TuttiFrutti/FuncStore.Convers.Tests/PhysMath/Mech/ForcesTests.cs).


### Looks good ... `</🪝>`

<b>... to stake out a repository for CV.</b> But it's not a solution

❗The contractor team of SmallForces knew that the thrust must be communicated in _newtons_. 
They took the hardware reported value (the engineers there traditionally operated in the "house" system) and honestly submitted it as _N_. 

Thus the first issue would be to allow limitation of the unit selection. 

```csharp

public enum In
{
    [Abbr("dyn")]
    dyne,

    [Abbr("N")]
    newton = 1_000_000_000_000,

    [Abbr("lbf")]
    pound_force = 4_448_222_000_000,

    [Abbr("kip")]
    kilopound = 1_000 * pound_force,

    [Abbr("pdl")]
    poundal = 138_254_954_376, // since 1877, Absolute English system
}
```
{}

And it's only one on the list of 

## Other cases

## Beyond

### Units are not only measurement systems

### Values are not only numbers

### Beyond a single crystal

Temp dep on pressure


|- **Features and omissions**\
|--- Instantiation flexibility\
|--- Modularity behind interface\
|--- Generic-ism !\
|--- Constants: predetermined, instantiated vs. generated (as for Ce(Pa)\
|--- Arithmetic ops\
|--- Comparison\
|--- Cache

|- Handbook\
|- Description

|- **Used decisions**\
|-- General\
|--- Testing - gradula\
|-- Specific

|- BIG PIC REQUIRED

|- **Structure** and **Source code**\
|--- MeasData\
|--- Funcs\
|----- Intro\
|----- Tests\
|--- U-Val

|- **What's next**\
|--- ❄️ Project snowflake

## Features and omissions

## Overload of math ops

It looks first absolutely natural and a must.

``` var sum = Length.Meter(1) + Length.Centimeter(2)```

This [shabby meme](https://github.com/Kyriosity/read-write/blob/main/readme%2B/pencraft/readme%2B/_rsc/_img/memes/CalmDown_0Cplus0Cis64F.jpg) must remind the obstacle. 
 
You must already know the right conclusion: only for common-zero factored units.


