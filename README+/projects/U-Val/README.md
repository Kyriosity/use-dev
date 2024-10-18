            🚧✏️🚧 ... **DRAFT** ... WORK in PROGRESS ... 🚧⌨️🚧
            ... REMOVE the LABEL when RELEASED ...
# Multifaceted Value :diamond_shape_with_a_dot_inside: (**U-Val**)

<p dir="rtl">?Gauges&nbsp;-<br />!<b>300</b>&nbsp;-<br />
?What 300&nbsp;-<br />?What gauges&nbsp;-</p>

 You may find the folklore right above dull but not pointless. Math deals with <ins>abstract numbers</ins><sup>_numerus numerans</sup>, computers operate on pure digits but not software developers and users.
 The "inputs" and "outputs" of software anchor to the material world, where numbers can be <ins>concrete</ins> (_numerus numeratus_) or <ins>denominated</ins> (_numerus denominatus_).
 
Communication (verbal, documents, and programs) more than often omits ENUMs, denominators, or units, which the title and context, or adopted system of measurements (say, SI) imply:

+ one apple,
+ temperature `36.6` OR FAHRENHEIT //
+ child age `7`
+ Your weekly payment will be `1'000` dollars [WHICH] use OF $$$


DECO may apply beyond numbers, for example: NAME

 Hallo, *Jack*

In the worst case default unit/measure may be ambiguous: 

<details>
2.7 baseline temperature of outer space,
            
<summary>&nbsp;<ins>&nbsp;Temperature of <code>36.6</code> looks familiar in <i>Kelvin</i> for liquid gases and in <i>Celsius</i> - for medicine</ins><b> .&nbsp;.&nbsp;.</b></summary>

WHAT MAKES THE MATTER WORSE - interchangeable at the same moment            
- An altitude on EU domestic flights is measured in _feet_ while variometers may show _meters_.

- A close approach of Earth to Mars is ca. `33'900'000` _miles_ but seems credible in _kilometers_ and _nmi_.
- A child's age of `7` can mean months and years.
- `Jack` can be family, given (not only on birth), and branded name.

RUNNING AHEAD:
Temp dep on pressure

- `$1'000` or `1'000€` have not only varying exchange divisions over the years, but differing purchase abilities for essential goods, 1GB of DRAM, or gold ounce&nbsp;**. . .**\
\___________

</details>

Not _denominated values_<sup>🔣</sup> in applications may rely on context or imply a single system of categorization (e.g. SI for physical values) and ... open wide the gate to errors, including ill-famed techno-disasters.

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


