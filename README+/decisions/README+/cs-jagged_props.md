> 🚧... DRAFT ... 🚧

# C# - "Fluid" interfaces, jagged generic properties

## Idea

Most applications need to present the same entity (model) with a different exposure: of items and read/write access. Consider developing a book register:

The set of items is quite usual and fixed: Title, ISBN, genre, years written, first-last published, original tongue(s) **(not xlation but some books are already polyglot ...), author(s), abstract, reviews.

* new (you can edit anything - ISBN)


## Realization

We can't escape making the number of interfaces, which equals the required combinations, but the technique matters.

You can simply create the nu interfaces, as I  

+ allows easy auto-generation (e.g. with T4)

### Stubbing the interface

The easiest way is to have the "full open" class and cast it to the interface.

DYNAMIC !
