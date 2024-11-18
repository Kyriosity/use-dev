# Test automation &mdash; Tests with multi-feed

Either it's [TDD](https://github.com/Kyriosity/read-write/tree/main/README%2B/software/tests/asDrive)<sup>⬅️</sup> or proof of the existing code, 
the conventional fashion is to pick a software piece (class, function, or something else) and write a particular test case over it, then consider and write another case, and so on.

Developing tests this way must wrap software features in nice <b>D</b><i>escriptive</i> <b>A</b><i>nd</i> <b>M</b><i>eaninigful</i> <b>P</b><i>hrases</i> (aka <b>DAMP</b>). 
However, this approach will combinatorially explode:

```mermaid
graph TD
    id1[Test data] -->|&nbsp;&nbsp;&nbsp;miscellaneous&nbsp;<br />&nbsp;combinations&nbsp;<br />&nbsp;of arguments&nbsp;<br />&nbsp;and settings&nbsp;&nbsp;&nbsp;| UT[PROOF<br />Arange/Act/Assert]
    id2[Invalid data] -->|null, nega, tress| UT
    Functionality -->|one, two, tress| UT
    Providers -->|<br />&nbsp;&nbsp;References&nbsp;<br />&nbsp;vs. Doubles<br />...| UT
```

Bloating tests mass will deteriorate: negligence, scrappy coverage, impeded navigation and OVER maintenance. Unless we ...

## DRY it

This approach is OVER and clutches testing projects with space with UNPACKED.

## What we have

## Going beyond

### Parametrization

```csharp
[Test, SOURCE(A, B2, C30, D04, ...)]
MeaninglessMethodName()
{
    var result = FACTORY.FuncOfTest(Arrange());
    ASSERT(result); // fail or success
}
```

#### SPOILERS

### Functions

### 



Unless we ...


routine for a particular run. Let's illustrate with a primitive:\
`Asserts: Root.Square(4) == 2`

The next step is to supply various data and expectations - something that a ripe framework will provide out of the box:\
`DataRows[]`\
or you may 


// Many frameworks support keywords for the data combinations

MULTI-FUNC and VARIOUS TYPES

Just take an entity (unit) of an application as a `class` or `function` and cover it with proofs.


An [example test](../../../src/TuttiFrutti/FuncStore.Convers.Tests/PhysMath/Dims/LengthsTests.cs) with two feeds

Stubdd

Let's put 3D glasses on 
3D exploded view

+ win-win: data <-> test
* ?? false true (by coincidental match)
* ?? accumulated warnings/errors/info (e.g. unparsed)

## Wrap up

Related topics\
|- Elusive unit of test

🔚
