<h1 align="center"><samp>Polymorphism<sup>➕</sup></samp> &nbsp; &mdash; &nbsp; Properties “Shifting”, or T-R/W Modelling</h1>

<table><tr><td><picture><img alt="&nbsp;Shape shifter pic" title="The Catman of Paris as&#013;&#010;a shape shifter species" 
 src="https://github.com/Kyriosity/read-write/blob/main/README%2B/_rsc/_img/snap/movies/1946.TheCatmanOfParis-poster_frag.jpg" /></picture></td><td>

> **The best evolutionary paradigm of OOP is directly mapping real-life things or abstractions,  their structures, and collections onto code objects.**

Object-oriented languages offer common paradigms with specific means and techniques to fine-tune or expand them.

Such customization traditionally involves classes and methods, while properties conceal even more potential. Next, we will bundle disparate **`C#`** techniques for _properties shifting_.

</td></tr></table>

```mermaid

mindmap
    props)"`**PROPERTIES** 
SHIFTING`"(
      T["`**GENERIC**
parametrization`"]

      EQ("`**ASSIGN overload**
#0010;
implicit operators will do the job.*`")

      RW("`**READ-WRITE**
#0010;
combinations of
get|_init_|set`")

      DYN{{ ̶ ̶D̶Y̶N̶A̶M̶I̶C̶
cast override
#0010;
something unwelcome and to be replaced with other techniques}}

```

<p align="right">* <sub>While your job is to define these operators.</sub><br />
** <sub>More techniques can be added later.</sub></p>

Let's keep a _**book**_ as a convenient sample of our survey. It has a title, author(s), ID(s), publishing agent, year and tongue, and other traits. 
If some of them fluctuate, as proposed below, then the inheritance approach will break on combinatory explosion.

```mermaid
classDiagram
  direction RL
  class Book {
    title : string
    tongues: Tongue
  }
  class Person{
    -id : int
    -name : string
  }
  class Organization{
    -id : int
    -name : string
  }
  Book "1" --o "1-n" Person : authored
  Book "1" --o "1" Organization : published

  style Student fill:#bbf,stroke:#333,stroke-width:4px
```

## Read-write ragged properties

The first solution will be to have a 

Create new()
   all fields are editable 
Present

Edit
   Summary, status, person info,


Consider that there must be read-only book views

Summary open for edit.

## Assign operator overloading

## Generic parametrization

Modeling generic properties with ragged access

Different ISBN formats or even no ISBN.

And is quite good with this but simple (otherwise it couldn't be a winning paradigm).

It's our job to advance OOD further.

https://github.com/Kyriosity/read-write/tree/main/README%2B/software/design/samples#still-models

# Prop<code>&lt;T&gt;</code> R/W classes
 
## Read-Write-Init &mdash; "Jagged" - fluctuating properties

> 🚧... DRAFT ... 🚧

# C#&nbsp;&nbsp;&mdash;&nbsp;&nbsp;Ragged properties (T-RW-Modelling)

In a decent application, a class may represent a document structure.

The business logic may specify miscellaneous access.

## Ideas

INTERFACE ONLY


Most applications need to present the same entity (model) with a different exposure of items and read/write access. Consider developing a book register:

The set of items is quite usual and fixed: Title, ISBN, genre, years written, first-last published, original tongue(s) **(not xlation but some books are already polyglot ...), author(s), abstract, reviews.

* new (you can edit anything - ISBN)


> :exclamation: This is not REPLACEMENT of FIRM interfaces

## Appendix. Realization 

We can't escape making the number of interfaces, which equals the required combinations, but the technique matters.


+ allows easy auto-generation (e.g. with T4)

### Stubbing the interface

The easiest way is to have the "full open" class and cast it to the interface.

DYNAMIC !

\___________\
🌘 2023-2025 .. image credit: the poster fragment of "The Catman of Paris", 1946, dir. Lesley Selander
