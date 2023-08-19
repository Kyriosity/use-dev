# Multifaceted Value

Alias: _**N-Val**_ :diamond_shape_with_a_dot_inside:

---
<div dir="rtl">!Gauges?&nbsp;&nbsp;&nbsp;-&nbsp;300&nbsp;-</dir>
<div dir="rtl">?What 300?&nbsp;&nbsp;&nbsp;-&nbsp;What gauges&nbsp;-</dir>
<p>&nbsp;</p>

You may find the folklore right above dull but not pointless. Math relies on pure numbers, and computers operate with them. However **and** chiefly, for devs **and** users, the inputs **and** outputs of software abstractions anchor to the material world.

And in the material world, even named values are devoid of meaning unless categorized. _Age_ of `7` can be months and years, `Smith` can be given, surname and trademark. A surface temperature of `36.6` is natural if Celsius for humans and Kelvin for the dark side of Neptune. Close approach to Mars as 33.900.000 sounds authentic both in miles and kilometers<sup>:rocket:</sup>.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:rocket:</sup> ...miles [according to NASA](https://mars.nasa.gov/all-about-mars/night-sky/close-approach/)

## So what's the problem?

The object-oriented design fits well with custom categorization but no popular programming language has pre-programmed structures, especially for physical units. 

Thus applications 

 - rely on context (and open door for disastrous scenarios),
 - imply a single system of categorization, e.g. SI for physical values (quite limited even within a single culture and location),
 - style procedural like `const absZero_Kelvin = 0` is unambigous but ugly to the OOP,
 - implement own solution (which re-invents the wheel).

## CRITICIZE BUT PROPOSE

Simply to have a shared solution based on experience of custom.

### Declare like a pro

```csharp
var temp = Temperature.Celsius();
```

## Design decision, principal to know

## Beyond the first sketch

Unions of values as square\
Value vs presentation\
Math optimization (function chaining, straightening camel calcs, accumulating inaccuracy, caching, unmanaged code, tree search)\
Differing types beyond a value

### PHYSICAL VALUES ARE A SEPARATE BIG SUB-DOMAIN

Unit systems

### NOT ONLY PHYSICAL VALUES (UValues) 

Currency exchange

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


