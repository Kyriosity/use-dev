# C# - Tasks as properties backup

Seasoned developers used to defer initialization/calculation to less or more "heavy" entities. In C# either with `Lazy<...>` or custom code like this:
<details>
<summary><ins>&nbsp;Deferred loading snipped&nbsp;</ins></summary>
&nbsp;
  
  ```csharp
public BigAndHeavy Ram => _ram ?? LoadAndHit();
private BigAndHeavy? _ram;
  ```
</details>

This allows to **a)**&nbsp;load the stuff on&nbsp;demand only, **b)**&nbsp;spread resources peaks, **c)**&nbsp;split suspense. Nonetheless, the suspense remains.

The power and storage of home laptops are excessive and mostly idle<sup>:video_game:</sup>, while platforms like .NET ensure the background running of multiple processes. Thus it's not crucial to delay tasks but to complete them as much as possible in the background, and seamlessly produce results when required.

&nbsp;&nbsp;&nbsp;&nbsp;<sup>:video_game:</sup> <sub>We mean usual office, browsers, business applications, and dev environments - not high performance servers, top games, video processing or mining.</sub>

## Tasks

🚧... TO BE CONTINUED ... 🚧

## Beyond simple scenarios

🚧... TO BE WRITTEN ... 🚧
