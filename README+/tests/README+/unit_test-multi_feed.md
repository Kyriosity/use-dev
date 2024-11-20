# Test automation &mdash; Tests with multi-feed

<p dir="rtl">DAMP vs DRY</p>

**Either [TDD](https://github.com/Kyriosity/read-write/tree/main/README%2B/software/tests/asDrive)<sup>⬅️</sup> or proof of the provided code, 
a conventional fashion is to pick a software entity (class, function, or something else) and write a particular test case over it, then consider and write other cases.**

Developing tests this way shall (not must) wrap features in nice <b>D</b><i>escriptive</i> <b>A</b><i>nd</i> <b>M</b><i>eaninigful</i> <b>P</b><i>hrases</i> (aka <mark><b>DAMP</b></mark>). 
However, this approach will combinatorially explode:

```mermaid
graph TD
    idCx[Context<br />&lpar;Arrange&rpar;] -->|<br />&nbsp;&nbsp;Arguments,&nbsp;&nbsp;<br />&nbsp;&nbsp;Test Data,&nbsp;&nbsp;<br />&nbsp;&nbsp;Settings&nbsp;&nbsp;<br />...| UT[TEST<br />Arange/Act/Assert]
    idFnc[Functionality<br />&lpar;Act&rpar;] -->|<br />&nbsp;&nbsp;Implementation A, B, C, ...&nbsp;<br >&nbsp;Sample func, ...&nbsp;</br>&nbsp;Stubs, Dummies&nbsp;&nbsp;<br />...| UT
    idSrv[Providers<br />&lpar;Arrange&rpar;] -->|<br />&nbsp;&nbsp;Imports, Services&nbsp;&nbsp;<br />&nbsp;&nbsp;vs. Mocks, Doubles&nbsp;&nbsp;<br />...| UT
    idAbs[Input abuse<br />&lpar;Arrange, Act&rpar;] -->|&nbsp;&nbsp;<i>null</i>s, out-of-range&nbsp;<br />&nbsp;&nbsp;<i>exception</i> makers,&nbsp;<br />&nbsp;invalid/illegal calls/funcs&nbsp;<br />...| UT

```
<details><summary><ins>&nbsp;Legend;&nbsp;</ins></summary>
    &nbsp;

Add here that arguments combinations can matter and their multitype (e.g. integer and floating point for the same calculation and even values).

#### Context

#### Abuse

\___________
</details>

## DRY it

Bloating tests mass will deteriorate: negligence, scrappy coverage, impeded navigation, and badly exorbitant maintenance. Unless we apply **D**_on't_ **R**_epeat_ **Y**_ourself_ (aka <mark><b>DRY</b></mark>) to our tests ...

Most frameworks will support one-dimensional scaling.

CUCUMBER

AUTO-COMBINATION

MULTITYPE

## Workarounding

The best thing ould be if 


LINK TO ASSERT-ACT breakup

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

Was it all about unit tests? Yes, but can work for others in the pyramid.

Related topics\
GRADUAL ASSERT
HOW MANY ASSERTS
|- Elusive unit of test

🔚
