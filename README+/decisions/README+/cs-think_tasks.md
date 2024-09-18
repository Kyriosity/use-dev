# Tasks as model

Most well-known templates/paradigms (MVC, MVP/MVVM, POCO) and tailored solutions rest on models. Developers bind actions and presentations to properties, which are ready static or changing values, calculated, or rendered by a service, or read from a storage.

That's nothing wrong with this approach (especially for logical division) but it's primitivity.

Direct implementation in responsive applications incurs perpetual patching of lags. 

## New thinking



## AUX Techniques. LAZY vs. PRELOAD

Behind either model or its tasks, there could be some tricks to make them even better.

### Laziness

Since the olden days, developers used to defer initialization/calculation of less or more "heavy" entities. This allows to **a)**&nbsp;load the stuff on&nbsp;demand only, **b)**&nbsp;spread resources peaks, **c)**&nbsp;split suspense (which nevertheless remains).

THOUGH LAZY LOAD is still practical

In C# you can do it either with `Lazy<...>` or custom code like this:

<details><summary><ins>&nbsp;Deferred loading snippet&nbsp;</ins></summary>
&nbsp;
  
  ```csharp
public BigAndHeavy Ram => _ram ?? LoadAndHit();
private BigAndHeavy? _ram;
  ```
</details>

Nowadays it's ALSO an anti-pattern.

### As an "anti-pattern"

### Praise and critique of preloading

The power and storage even of home laptops are multicore, excessive, and mostly idle<sup>:video_game:</sup>, while platforms like .NET ensure the background running of multiple processes. The story got inverted - it's not crucial to delay tasks but to complete them as much as possible earlier and in the background, and then seamlessly produce results when required.

It doesn't matter if you "pre-load" a dozen things, of which only one will be selected by the user (e.g. next wizard page dependent on differing selections). Compare to warehouses, where it costs to keep a supply of goods, for a single purpose to be delivered within a day when the customer orders.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:video_game:</sup> <sub>We mean usual office, browsers, business applications, and dev environments (not high-performance servers, top games, video processing or mining).</sub>

## SOLUTIO

> 🚧 ... DRAFT ... 🚧

CHESS IMPLEMENTATION on Task-UndoRedo-View
