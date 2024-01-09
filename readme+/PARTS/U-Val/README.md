            🚧🚧🚧 ... **DRAFT** ... 🚧🚧🚧
            ... REMOVE the LABEL when RELEASED ...
# Multifaceted Value :diamond_shape_with_a_dot_inside: (includes **U-Val**)

<div dir="rtl">?Gauges&nbsp;-</div>
<div dir="rtl">!300&nbsp;-</div>
<div dir="rtl">?What 300&nbsp;-</div>
<div dir="rtl">?What gauges&nbsp;-</div>
<p>&nbsp;</p>

 You may find the folklore right above dull but not pointless. Math relies on pure numbers, computers operate on pure digits but not developers and users.  
 
 The inputs and outputs of applications anchor to the material world, where even named values are meaningless without unit, category, or benchmark. 

- A child's age of `7` can be months and years.
- Temperature of `36.6` looks native in _Kelvin_ for liquid gases and in _Celsius_ - for medicine.
- Close approach to Mars as `33'900'000` seems credible in miles and kilometers <sup>(miles according to [NASA](https://mars.nasa.gov/all-about-mars/night-sky/close-approach/))</sup>
- `Jack` can be family, given (not only on birth), and branded name.
- `$1'000` or `1'000€` has temporal purchase ability with dissimilar curves for essential goods, 1GB of RAM, and gold ounce

Values in applications may

 - rely on context<sup>:warning:</sup>,
 - imply a single system of categorization, e.g. SI for physical values<sup>:warning:</sup> (rather limited scope),
 - style in old fashion like `const Temperature_AbsZero_Kelvin = 0.00` (unambiguous but ugly to the object-oriented sight),
 - implement a tailored solution - here we will try to make a shared one.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:warning:</sup>&nbsp;<sub>Both open wide the gate to errors, including ill-famed techno-disasters.</sub>

|- **Features and omissions**\
|--- Arithmetic ops\
|--- Comparisson\
|--- Cache\

|- Handbook\
|- Description\

|- **Used decisions**\
|-- General\
|--- Testing - gradula\
|-- Specific

|- **Source code**\
|--- MeasData\
|--- Funcs\
|----- Tests\
|--- U-Val

|- **What's next**\
|--- ❄️ Project snowflake

## Features and omissions

## Overload of math ops

Looks first absolutely natural and a must.

``` var sum = Length.Meter(1) + Length.Centimeter(2)```

This [shabby meme](https://github.com/Kyriosity/read-write/blob/main/readme%2B/pencraft/readme%2B/_rsc/_img/memes/CalmDown_0Cplus0Cis64F.jpg) must remind the obstacle. 
 
You must already know the right conclusion: only for common-zero factored units.


