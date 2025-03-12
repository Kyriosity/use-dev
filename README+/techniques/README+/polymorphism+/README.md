 <h1 align="center">OOP&nbsp;&nbsp;&mdash;&nbsp;&nbsp;Polymorphism&nbsp;&nbsp;&mdash;&nbsp;&nbsp;<i>expanded</i></h1>

Two of the four pillars beneath object-oriented programming are plain: <mark>**encapsulation**</mark> and _**inheritance**_, &mdash; when the word makes an explanation.

**_Abstraction_** is abstract by definition but doesn't need much portrayal. It is the essence of thinking and programming: object-oriented or not.

<span title="&nbsp;&thinsp; Greek:&#013;&#010&nbsp;πολύ&nbsp;&nbsp;&mdash;&nbsp;&nbsp;many&#013;&#010&nbsp;μορφ&nbsp;&nbsp;&mdash;&nbsp;&nbsp; form"><ins>_**Polymorphism**_</ins></span> is vague and has many forms of "many forms":

+ **subtypes** &mdash; derivative of inheretance,
+ **parametric** &mdash; as generics in C++, Python, Java, or C#,
+ **name sharing** &mdash; [ad hoc] method overriding/overloading,
+ _others_ &mdash; some of which we want to discuss next.

# <a id="prop-shift" />Properties <i>shifting</i>

The best evolutionary paradigm of OOP is the direct mapping of real life things, structures, and abstractions onto code objects. 
In language-level impementations polymorphism comes to fine-tune classes and methods while properties are relatively neglected.

Let's address two major issues:

READ/WRITE/INIT combinations

MAYVE MORE LATER

🚧🚧🚧🚧🚧🚧🚧 ... under construction ... 🚧🚧🚧🚧🚧🚧🚧

Modelling generic properties with ragged access

And is quite good with this but simple (otherwise it couldn't be a winning paradigm).

it's our job to advance OOD further.

https://github.com/Kyriosity/read-write/tree/main/README%2B/software/design/samples#still-models

# Prop<code>&lt;T&gt;</code> R/W classes
 
## Read-Write-Init &mdash; "Jagged" - fluctuating properties

> 🚧... DRAFT ... 🚧

# C#&nbsp;&nbsp;&mdash;&nbsp;&nbsp;Ragged properties (T-RW-Modelling)

In a decent application, a class may represent a document structure.

The business logic may specify miscellaneous .

## Ideas

INTERFACE ONLY


Most applications need to present the same entity (model) with a different exposure: of items and read/write access. Consider developing a book register:

The set of items is quite usual and fixed: Title, ISBN, genre, years written, first-last published, original tongue(s) **(not xlation but some books are already polyglot ...), author(s), abstract, reviews.

* new (you can edit anything - ISBN)


> :exclamation: This is not REPLACEMENT of FIRM interfaces

## Realization

We can't escape making the number of interfaces, which equals the required combinations, but the technique matters.


+ allows easy auto-generation (e.g. with T4)

### Stubbing the interface

The easiest way is to have the "full open" class and cast it to the interface.

DYNAMIC !

\___________\
🌘 2023-2025


