# "Lurking" initialization in 🎼C#

> **Initializing objects isn't an issue until particular wishes are met or limits are hit.**

## Reminder and setup

C# offers two "mainstream" ways of parametrization objects on creation:

* **C&thinsp;o&thinsp;n&thinsp;s&thinsp;t&thinsp;r&thinsp;u&thinsp;c&thinsp;t&thinsp;o&thinsp;r&thinsp;s**

Many techniques and frameworks (let alone serialization) disregard "parameterful" constructors however they have one great advantage:

> You can keep certain parameters exposed only once in the construction call that corresponds to the word "initialization".

Other edges as `params` are syntax excellence.

* **I&thinsp;n&thinsp;i&thinsp;t&thinsp;i&thinsp;a&thinsp;l&thinsp;i&thinsp;z&thinsp;e&thinsp;r&thinsp;s**

[Object initializers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers)<sup>🪟</sup> are error-proof and more flexible (can set even readonly fields through `init` props). 

The possible disadvantage is properties remain exposed in the object (even as read-only).

## Posers

## Construction from type argument

The [`new`](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/new-constraint)<sup>🪟</sup> constraint allows to instantiate `<T>`.

Required keyword will spoil 

## Builders 

new() constraint

Constructors

## Solutions

### Generic parametrization of generics !


 🚧 🏗️ 🚧 ... to be continued ... 🚧🐝🚧

\___________\
🌘 2025
