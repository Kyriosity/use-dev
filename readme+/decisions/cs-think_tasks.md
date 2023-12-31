> 🚧 ... DRAFT ... 🚧

# C# - Tasks as model

## Critique: Laziness

In the olden days, developers used to defer initialization/calculation of less or more "heavy" entities. This allows to **a)**&nbsp;load the stuff on&nbsp;demand only, **b)**&nbsp;spread resources peaks, **c)**&nbsp;split suspense, which nevertheless remains.

In C# you can do it either with `Lazy<...>` or custom code like this:
<details>
<summary><ins>&nbsp;Deferred loading snipped&nbsp;</ins></summary>
&nbsp;
  
  ```csharp
public BigAndHeavy Ram => _ram ?? LoadAndHit();
private BigAndHeavy? _ram;
  ```
</details>

However nowadays it's an anti-pattern.

The power and storage even of home laptops are multicore, excessive, and mostly idle<sup>:video_game:</sup>, while platforms like .NET ensure the background running of multiple processes. The story got inverted - it's not crucial to delay tasks but to complete them as much as possible earlier and in the background, and then seamlessly produce results when required.

It doesn't matter if you "pre-load" dozen things, of which only one will be selected by the user (e.g. next wizard page dependent on differing selections). Compare to warehouses, where it costs to keep a supply of goods, for a single purpose to be delivered within a day when the customer orders.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:video_game:</sup> <sub>We mean usual office, browsers, business applications, and dev environments (not high-performance servers, top games, video processing or mining).</sub>

## Critique

Well-known templates (e.g. MVVM), as an idea and shared implementations, give a static picture of models. Developers bind to properties, which are a constant value, calculated, or brought by a service, read from a database.

Sometimes this works as a clock in "greenhouse" conditions, but with any step inside it begins to UI + DEPENDENCY BREAK

## Proposed solution: VP?


