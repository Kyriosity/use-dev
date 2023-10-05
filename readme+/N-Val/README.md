🚧🚧🚧 ... **DRAFT** ... 🚧🚧🚧
# Multifaceted Value :diamond_shape_with_a_dot_inside: (_aka_ **N-Val**)

<div dir="rtl">?Gauges&nbsp;-</dir>
<div dir="rtl">!300&nbsp;-</dir>
<div dir="rtl">?What 300&nbsp;-</dir>
<div dir="rtl">?What gauges&nbsp;-</dir>
<p>&nbsp;</p>

You may find the folklore right above dull but not pointless. Math relies on pure numbers, computers operate on pure digits but not developers and users. 

The inputs and outputs of applications sooner or later anchor to the material world and therein even named numbers (values❗) remain meaningless unless categorized in (physical ❗) units. 

* Child's _age_ of `7` can be months and years, `Smith` can be given, surname and trademark.
* A temperature of `36.6` may speak of humans in _Celsius_ and about superconductivity in _Kelvin_.
* Close approach to Mars as 33.900.000 sounds credible in miles and kilometers...\
<sub>...miles [according to NASA](https://mars.nasa.gov/all-about-mars/night-sky/close-approach/)</sub>

BIG NAV !

## Status quo

Thus applications 

 - rely on context (and open door for disastrous scenarios),
 - imply a single system of categorization, e.g. SI for physical values (rather limited even within a single culture and location, or enterprise),
 - style procedural like `const absZero_Kelvin = 0` is unambiguous but ugly to the object-oriented sight,
 - implement a tailored solution.

All of these are workarounds and malpractices. LIST OF ACCIDENTS !

The object-oriented design facilitates custom categorization but no mainstream (programming) language offers pre-determined standards and definitions, particularly for physical units and constants. 

## What this project does

Just a shared one based on the experience of those tailored.

```csharp
var heating = Temperature.Celsius(27.6);
var spaceZero = Temperature.Kelvin<double>(2.725);
var stationAmbient = Temperature.Celsius(20);
var diffENTROPY = NASA.CALC_ENTROPY(soundEuroAustronaut.Fahrenheit - spaceZero);

```

. NET Solution:\
|- Tests\
|- Source code

Features and Design decisions\

|- Arithmetic overloads\
|- Comparison\
|- Indexing\
|- Fabrics\
|- Hooks

## Is multifaceted the right word?

Is the term and project not too pretentious, while it's a straightforward conversion?

## Principal decision

### Math ops overload

### Equality overload and Equal override

It's a rational rush after implementing the instantiation to overload math operators.

<details>
<summary>Which will appear meaningless after short pondering</summary> 
 Even 0 based values won't help

</details>
 
## Beyond the first sketch

Unions of values as square\
Value vs. presentation\
Math optimization (function chaining, straightening camel calculations (incl. intermediate overflow), accumulating inaccuracy, caching, unmanaged code, tree search)\
Differing types beyond a value

### PHYSICAL VALUES ARE A SEPARATE BIG SUB-DOMAIN

Unit systems

### NOT ONLY PHYSICAL VALUES (UValues) 

Currency exchange (especially in years with inflation/deflation)

### NOT ONLY NUMBERS (

Hashes of value\
Translation\
Movie scores from diff db

## Implementation
-> .NET Solution\
Uses:
|- Jagged-set interfaces
|- 

| Jagged-set interfaces 
|- 
| Jagged-set interfaces 
|- 


