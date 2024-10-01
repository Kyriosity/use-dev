            🚧✏️🚧 ... **DRAFT** ... WORK in PROGRESS ... 🚧⌨️🚧
            ... REMOVE the LABEL when RELEASED ...
# Multifaceted Value :diamond_shape_with_a_dot_inside: (**U-Val**)

<div dir="rtl">?Gauges&nbsp;-</div>
<div dir="rtl">!300&nbsp;-</div>
<div dir="rtl">?What 300&nbsp;-</div>
<div dir="rtl">?What gauges&nbsp;-</div>
<p>&nbsp;</p>

 You may find the folklore right above dull but not pointless. Math deals with _abstract numbers_<sup>🔣</sup>, computers operate on pure digits but not developers and users.  
 
 The inputs and outputs of applications anchor to the material world, where even _concrete values_<sup>🔣</sup> may be ambiguous: 

<details>
<summary>&nbsp;<ins>A child's age of <code>7</code> can be months or years&nbsp;</ins><b> .&nbsp;.&nbsp;.</b></summary>
            
- An altitude on EU domestic flights is measured in _feet_ while variometers may show _meters_.
- Temperature of `36.6` looks native in _Kelvin_ for liquid gases and in _Celsius_ - for medicine.
- A close approach of Earth to Mars is ca. `33'900'000` _miles_ but seems credible in _kilometers_ and _nmi_.
- `Jack` can be family, given (not only on birth), and branded name.
- `$1'000` or `1'000€` have not only varying exchange divisions over the years, but differing purchase abilities for essential goods, 1GB of DRAM, or gold ounce&nbsp;**. . .**\
\___________

</details>

Not _denominated values_<sup>🔣</sup> in applications may rely on context or imply a single system of categorization (e.g. SI for physical values) and ... open wide the gate to errors, including ill-famed techno-disasters.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>🔣</sup> <sub>These are formal definitions, we will rely on. Aka _numerus numerans_, _numerus numeratus_, and _numerus denominatus_. correspondingly</sub>

 Univocal coding like `const Temperature_AbsZero_Kelvin = 0.00` is old-fashioned and ugly to the object-oriented eye. As a picky pro you'd PREFER IT TO THE SYNTAX that our U-VAL-EMBLEM renders.

## Case DEMO

Let's present our FEAT take an epic story of the poor [Mars Climate Orbiter] 
...

...

and show how we could make its software not only NEATER but save about half a billion $$.


 total impulse produced by thruster firings produced results in pound-force seconds. The trajectory calculation software then used these results – expected to be in newton-seconds (incorrect by a factor of 4.45)

 https://llis.nasa.gov/llis_lib/pdf/1009464main1_0641-mr.pdf

 ## Working TTL


 As a good developer, you will come to a better view, like `Heating.Max[Celcius] = 82.15` or `Landing.Speed.Knots` vs `.KmPerHour`. Then you will think about ways of initialization, conversion functions, math ops, constants, and other headaches. 

 And here you are, where such a framework is available for use, alteration, or just as a concept.

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


