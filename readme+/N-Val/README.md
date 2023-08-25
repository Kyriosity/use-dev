# Multifaceted Value

Alias: _**N-Val**_ :diamond_shape_with_a_dot_inside:

---
<div dir="rtl">!Gauges?&nbsp;&nbsp;&nbsp;-&nbsp;300&nbsp;-</dir>
<div dir="rtl">?What 300?&nbsp;&nbsp;&nbsp;-&nbsp;What gauges&nbsp;-</dir>
<p>&nbsp;</p>

You may find the folklore right above dull but not pointless. Math relies on pure numbers, and computers operate with them. However **and** chiefly, for devs **and** users, the inputs **and** outputs of software abstractions anchor to the material world.

And in the material world, even named values remain meaningless unless categorized. 

* _Age_ of `7` can be months and years, `Smith` can be given, surname and trademark.
* A temperature of `36.6` is natural in _Celsius_ for humans and in _Kelvin_ for supercoductivity.
* Close approach to Mars as 33.900.000 sounds authentic both in miles and kilometers<sup>:rocket:</sup>.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<sup>:rocket:</sup> ...miles [according to NASA](https://mars.nasa.gov/all-about-mars/night-sky/close-approach/)

## So what's the problem?

The object-oriented design fits fine with custom categorization but no popular programming language pre-determines standards and definitions, particularly for physical units. 

Thus applications 

 - rely on context (and open door for disastrous scenarios),
 - imply a single system of categorization, e.g. SI for physical values (rather limited even within a single culture and location, or enterprise),
 - style procedural like `const absZero_Kelvin = 0` is unambiguous but ugly to the object-oriented sight,
 - implement a tailored solution.

## Solution

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


