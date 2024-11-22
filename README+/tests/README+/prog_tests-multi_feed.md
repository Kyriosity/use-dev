# QA Automation &mdash; Tests with multi-feed

<table><tr><td><p align="center">
    ⬅️<i>read-write</i><br><b><a href="https://github.com/Kyriosity/read-write/tree/main/README%2B/software/QA">&thinsp;QA&thinsp;</a></b> and <b><a href="https://github.com/Kyriosity/read-write/tree/main/README%2B/software/tests">&thinsp;TESTS&thinsp;</a></b>
</p></td><td>
    This article projects concerns of tests <a href="https://github.com/Kyriosity/read-write/blob/main/README+/software/tests/asQA/README+/tests-damp_vs_dry.md#Combinatorial-explosion">combinatorial explosion</a> onto practical decisions.
</td></tr></table>


Add here that arguments combinations can matter and their MULTITYPE POLY (e.g. integer and floating point for the same calculation and even values).

#### Context

#### Abuse

\___________
</details>

## DRY it

"Multidimensional" combinations will
make a mess of tests mass and  deteriorate its quality: negligence, scrappy coverage, impeded navigation, and badly exorbitant maintenance.

we may live with this, since tests are not the product, .

or apply **D**_on't_ **R**_epeat_ **Y**_ourself_ (aka <mark><b>DRY</b></mark>) to our tests ...

Most frameworks will support one-dimensional scaling.

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
